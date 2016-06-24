namespace Music_Genre_Grouper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        #region Fields

        FolderWalker folderWalker;
        SortedDictionary<string, string> genreGroups;
        SortedDictionary<string, List<string>> filepathsByGenreGroup;
        List<string> unmatchedGenres;

        #endregion Fields

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Event Handlers

        private void StartButton_Click(object sender, EventArgs e)
        {
            genreGroups = new SortedDictionary<string, string>();
            foreach (var item in textBox1.Lines)
            {
                string genre = item.Substring(item.IndexOf(':') + 1).Trim();
                string group = item.Substring(0, item.IndexOf(':'));

                if (!genreGroups.ContainsKey(genre))
                    genreGroups.Add(genre, group);
            }

            folderWalker = new FolderWalker(fileFolderTextbox1.AbsolutePath, true);
            folderWalker.Finished += FolderWalker_Finished;
            folderWalker.Start();
        }

        #endregion Event Handlers

        #region Methods

        private void FolderWalker_Finished(List<System.IO.DirectoryInfo> ProcessedFolders, List<System.IO.FileInfo> ProcessedFiles)
        {
            unmatchedGenres = new List<string>();
            filepathsByGenreGroup = new SortedDictionary<string, List<string>>();
            foreach (var musicFile in ProcessedFiles)
            {
                if (musicFile.Extension.Equals(".mp3", StringComparison.CurrentCultureIgnoreCase))
                {
                    TagLib.File tagFile = TagLib.File.Create(musicFile.FullName);
                    foreach (var genre in tagFile.Tag.Genres)
                    {
                        if (genreGroups.ContainsKey(genre))
                        {
                            string genreGroup = genreGroups[genre];

                            if (filepathsByGenreGroup.ContainsKey(genreGroup))
                                filepathsByGenreGroup[genreGroup].Add(musicFile.FullName);
                            else
                                filepathsByGenreGroup.Add(genreGroup, new List<string>());

                            if (ChangeGenreCheckbox.Checked)
                            {
                                //tagFile.Save();
                            }
                        }
                        else
                        {
                            unmatchedGenres.Add(genre);
                        }
                    }
                }
            }

            // Save each m3u playlist
            if (CreateM3UCheckbox.Checked)
            {
                foreach (var genreGroup in filepathsByGenreGroup)
                {
                    List<string> relativePaths = new List<string>();
                    foreach (var filepath in genreGroup.Value)
                    {
                        string relativePath = PathFunctions.RelativePath(fileFolderTextbox1.AbsolutePath,filepath);
                        relativePaths.Add(relativePath);
                    }

                    File.WriteAllLines(Path.Combine(fileFolderTextbox1.AbsolutePath, genreGroup.Key + ".m3u"), relativePaths.ToArray());
                }
            }

            MessageBox.Show("Finished.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Methods
    }
}