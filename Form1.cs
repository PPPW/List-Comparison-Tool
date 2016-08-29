using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FileCheck
{
    public partial class Form1 : Form
    {
        private string ext1 = "xlsx", ext2 = "xlsx";
        private string[] files1String = new string[] {};
        private string[] files2String = new string[] {};
        private bool ignoreTextChanged = false;
        private string pattern_ = @".*?\.(.*)";

        /// <summary>
        /// constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// find all files given path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void path1_Changed(object sender, EventArgs e)
        {       
            ignoreTextChanged = true;
            getFilesGivenDir(path1, file1, ref files1String, count1, ext1);
            ignoreTextChanged = false;
        }

        private void path2_Changed(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            getFilesGivenDir(path2, file2, ref files2String, count2, ext2);
            ignoreTextChanged = false;
        }

        private void getFilesGivenDir(TextBox path, TextBox file, ref string[] filesString, Label count, string ext)
        {
            ignoreTextChanged = true;
            string dir = path.Text.Trim();
            if (Directory.Exists(dir))
            {
                filesString = Directory.GetFiles(dir, "*" + ext, SearchOption.AllDirectories);
                filesString =  filesString.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                file.Text = String.Join("\r\n", filesString);
                count.Text = filesString.Length.ToString();
            }
            else
            {
                file.Text = "Dir not exist";
            }
            ignoreTextChanged = false;
        }

        /// <summary>
        /// set file extension
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extension1_Changed(object sender, EventArgs e)
        {
            if (extension1.Text.Equals(""))
                ext1 = extension1.Text;
            else
                ext1 = "." + extension1.Text;
            ignoreTextChanged = true;
            getFilesGivenDir(path1, file1, ref files1String, count1, ext1);            
            ignoreTextChanged = false;
        }

        private void extension2_TextChanged(object sender, EventArgs e)
        {
            if (extension2.Text.Equals(""))
                ext2 = extension2.Text;
            else
                ext2 = "." + extension2.Text;
            ignoreTextChanged = true;
            getFilesGivenDir(path2, file2, ref files2String, count2, ext2);
            ignoreTextChanged = false;
        }

        /// <summary>
        /// get file names without path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noPath_Click(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            getFileNames(file1, ref files1String);                
            ignoreTextChanged = false;
        }

        private void noPath2_Click(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            getFileNames(file2, ref files2String);      
            ignoreTextChanged = false;
        }

        private void getFileNames(TextBox file, ref string[] filesString)
        {
            if (filesString != null)
            {
                filesString = filesString.Select(x => Path.GetFileName(x))
                    //.Where(x => !string.IsNullOrEmpty(x))
                    .ToArray();
                file.Text = String.Join("\r\n", filesString);
            }
        }

        /// <summary>
        /// get basename 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void basename_Click(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            getBasenames(file1, ref files1String);     
            ignoreTextChanged = false;
        }

        private void basename2_Click(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            getBasenames(file2, ref files2String);      
            ignoreTextChanged = false;
        }

        private void getBasenames(TextBox file, ref string[] filesString)
        {
            if (filesString.Length != 0)
            {
                filesString = filesString.Select(x => Path.GetFileNameWithoutExtension(x)).ToArray();
                file.Text = String.Join("\r\n", filesString);
            }
        }

        /// <summary>
        /// sort files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sort_Click(object sender, EventArgs e)
        {        
            ignoreTextChanged = true;
            sortFiles(file1, ref files1String);
            ignoreTextChanged = false;
        }

        private void sort2_Click(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            sortFiles(file2, ref files2String);      
            ignoreTextChanged = false;
        }

        private void sortFiles(TextBox file, ref string[] filesString) 
        {
            if (filesString != null)
            {
                Array.Sort<string>(filesString);
                file.Text = String.Join("\r\n", filesString);
            }
        }

        /// <summary>
        /// unique: remove duplicated files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniq_Click(object sender, EventArgs e)
        {       
            ignoreTextChanged = true;
            uniqFiles(file1, ref files1String, count1);
            ignoreTextChanged = false;
        }

        private void uniq2_Click(object sender, EventArgs e)
        {
            ignoreTextChanged = true;
            uniqFiles(file2, ref files2String, count2);
            ignoreTextChanged = false;
        }

        private void uniqFiles(TextBox file, ref string[] filesString, Label count) 
        {
            if (filesString != null)
            {
                filesString = filesString.Distinct().ToArray();
                file.Text = String.Join("\r\n", filesString);
                count.Text = filesString.Length.ToString();
            }
        }

        /// <summary>
        /// compare the two file lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void compare_Click(object sender, EventArgs e)
        {
            if (files1String != null)
            {
                // assert files2String can't be null
                if (files2String.Length != 0)
                {
                    var dups = files1String.Intersect(files2String).ToArray();
                    duplicate.Text = String.Join("\r\n", dups);
                    countInBoth.Text = dups.Length.ToString();

                    var onlyIn1String = files1String.Except(files2String).ToArray();
                    onlyIn1.Text = String.Join("\r\n", onlyIn1String);
                    countOnlyA.Text = onlyIn1String.Length.ToString();

                    var onlyIn2String = files2String.Except(files1String).ToArray();
                    onlyIn2.Text = String.Join("\r\n", onlyIn2String);
                    countOnlyB.Text = onlyIn2String.Length.ToString();
                }
                else
                {
                    var dups = files1String.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key)
                        .ToArray();
                    duplicate.Text = String.Join("\r\n", dups);
                    countInBoth.Text = dups.Length.ToString();

                    var uniqs = files1String.Except(dups).ToArray();
                    onlyIn1.Text = String.Join("\r\n", uniqs);
                    countOnlyA.Text = uniqs.Length.ToString();

                    onlyIn2.Text = "";
                    countOnlyB.Text = "";
                }
            }
        }

        /// <summary>
        /// change files by typing
        /// if text is changed in anywhere else, must first set ignoreTextChanged to true
        /// otherwise, the following events will be invoked
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filesString"></param>
        /// <param name="count"></param>
        private void changeFilesByTyping(TextBox file, ref string[] filesString, Label count)
        {
            if (file.Text != null)
            {
                filesString = file.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                // striping it here will create display problem, so save it to temp
                string[] filesStringTemp =  filesString.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                if (filesStringTemp.Length == 1)
                    filesString = file.Text.Split(new string[] { "\t" }, StringSplitOptions.None);
                // show the content to user anyway, but stripped all empty strings
                file.Text = String.Join("\r\n", filesString);
                filesString =  filesStringTemp;
                count.Text = filesString.Length.ToString();
            }
        }

        private void file1_TextChanged(object sender, EventArgs e)
        {
            if (ignoreTextChanged) return;
            changeFilesByTyping(file1, ref files1String, count1);
        }

        private void file2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file2.Text))
            {
                compare.Text = "check dups in (a)";
                inBothLabel.Text = "dups in (a):";
                onlyInALabel.Text = "uniqs in (a):";
                onlyInBLabel.Text = "";
                countOnlyB.Text = "";
            }
            else
            {
                compare.Text = "compare (a) && (b)";
                inBothLabel.Text = "In both:";
                onlyInALabel.Text = "Only in (a):";
                onlyInBLabel.Text = "Only in (b):";
            }
            if (ignoreTextChanged) return;
            changeFilesByTyping(file2, ref files2String, count2);
        }

        /// <summary>
        /// regex to replace the file with the first group
        /// remove files that don't match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pattern_TextChanged(object sender, EventArgs e)
        {
            pattern_ = pattern.Text;
        }

        private void match_Click(object sender, EventArgs e)
        {            
            if (files1String != null)
            {
                files2String = files1String.Select(x => 
                {
                    foreach (Match match in Regex.Matches(x, pattern_))
                        return match.Groups[1].ToString();
                    return "";
                }).ToArray();
                files2String =  files2String.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                ignoreTextChanged = true;
                file2.Text = String.Join("\r\n", files2String);
                ignoreTextChanged = false;
                count2.Text = files2String.Length.ToString();
            }
        }

        /// <summary>
        /// To enable ctrl-a for all the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void file1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) 
                file1.SelectAll(); 
        }

        private void file2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) 
                file2.SelectAll();
        }

        private void duplicate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) 
                duplicate.SelectAll();
        }

        private void onlyIn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) 
                onlyIn1.SelectAll();
        }

        private void onlyIn2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) 
                onlyIn2.SelectAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void extractField_Click(object sender, EventArgs e)
        {            
            int field_;
            if (Int32.TryParse(field.Text, out field_))
            {
                if (field_ == 0)
                    return;
                files2String = files2String.Select(x => 
                {
                    string[] xFields = x.Split(new string[] { "\t" }, StringSplitOptions.None);
                    if (xFields.Length >= field_)
                    {
                        return xFields[field_ - 1];
                    }
                    else
                        return x;
                }).ToArray();
                files2String =  files2String.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                ignoreTextChanged = true;
                file2.Text = String.Join("\r\n", files2String);
                ignoreTextChanged = false;
                //count2.Text = files2String.Length.ToString();
            }                
        }

    }
}
