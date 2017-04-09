using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Story_Writer
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        string[] articals = { "the", "a", "one", "some", "any" };
        string[] nouns = { "boy", "girl", "dog", "town", "car" };
        string[] verb = { "drove", "jumped", "ran", "walked", "skipped" };
        string[] preposition = { "to", "from", "over", "under", "on" };

        public Form1()
        {

            InitializeComponent();

            label1.Text = "Click to generate random sentences.";
   
        }

        private string Sentence()
        {
            List<string> collectionOfArticals = new List<string>();

            int randArticals = random.Next(0, articals.Length);
            string word = articals[randArticals];

            int randNouns = random.Next(0, nouns.Length);
            string word2 = nouns[randNouns];

            int randVerbs = random.Next(0, verb.Length);
            string word3 = verb[randVerbs];

            int randPrep = random.Next(0, preposition.Length);
            string word4 = preposition[randPrep];

            int randArticals2 = random.Next(0, articals.Length);
            string word5 = articals[randArticals2];

            int randNouns2 = random.Next(0, nouns.Length);
            string word6 = nouns[randNouns2];

            return UpperCaseFirst(word) + " " + word2 + " " + word3 + " " + word4 + " " + word5 + " " + word6;

        }

        private void CreateSentences()
        {
            for (int i = 0; i < 10; i++)
            {
                textBox1.AppendText(Sentence() + "." + "\r\n");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CreateSentences();
        }

        private static string UpperCaseFirst(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
