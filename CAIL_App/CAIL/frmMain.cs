using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCompair_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AID(rtCode1.Text, rtCode2.Text).ToString(), "", MessageBoxButtons.OK);
            
        }



        private Double AID(String CodeAlg1, String CodeAlg2)
        {
            String[] Alg1 = MakeArray(CodeAlg1);
            String[] Alg2 = MakeArray(CodeAlg2);
            int SizeAlg1 = 0, SizeAlg2 = 0;
            foreach (String Cell1 in Alg1)
                SizeAlg1++;
            foreach (String Cell2 in Alg2)
                SizeAlg2++;

            int Size = (SizeAlg1 < SizeAlg2) ? SizeAlg2 : SizeAlg1;            
            Double[,] CDDM = new Double[SizeAlg1, SizeAlg2];
            for (int i = 0; i < SizeAlg1; i++)
            {
                for (int j = 0; j < SizeAlg2; j++)
                {
                    CDDM[i, j] = CDD(Alg1[i], Alg2[j]);
                }
            }
            Double SumCellMax = 0;
            while ((SizeAlg1 > 0) && (SizeAlg2 > 0))
            {
                Double CellMax = 0;
                int Mi = 0, Mj = 0;
                Double[,] OldCDDM = new Double[SizeAlg1, SizeAlg2];
                for (int i = 0; i < SizeAlg1; i++)
                {
                    for (int j = 0; j < SizeAlg2; j++)
                    {
                        if (CDDM[i, j] > CellMax)
                        {
                            Mi = i; Mj = j;
                            CellMax = CDDM[i, j];
                        }
                        OldCDDM[i, j] = CDDM[i, j];
                    }
                }

                SumCellMax += CellMax;
                CDDM = new Double[SizeAlg1 - 1, SizeAlg2 - 1];

                for (int i = 0; i < SizeAlg1; i++)
                {
                    for (int j = 0; j < SizeAlg2; j++)
                    {
                        if (j < Mj)
                        {
                            if (i < Mi)
                            {
                                CDDM[i, j] = OldCDDM[i, j];
                            }
                            else
                            {
                                if (i > Mi) CDDM[i - 1, j] = OldCDDM[i, j];
                            }
                        }
                        else
                        {
                            if (j > Mj)
                            {
                                if (i < Mi)
                                {
                                    CDDM[i, j - 1] = OldCDDM[i, j];
                                }
                                else
                                {
                                    if (i > Mi) CDDM[i - 1, j - 1] = OldCDDM[i, j];
                                }
                            }
                        }

                    }
                }
                SizeAlg1--;
                SizeAlg2--;   
            }
            return 1-(SumCellMax / Size);
        }
/// <summary>
/// This function builds Array of Symbols from CAIL Code
/// </summary>
/// <param name="Code">CAIL Standard Code</param>
/// <returns>A array of Symbols</returns>
        private String[] MakeArray(String Code)
        {
            Char ch;
            String Str = "", Cell = "";
            int SArray = 0;

            String[] CodeArray = new String[0];
            String[] OldCodeArray  = new String[0];           
            

            for (int i = 0; i <= Code.Length; i++)
            {
                if (i < Code.Length)
                {
                    ch = Code[i];
                    if (ch == '\n')
                    {
                        if (IsConjuction(Str.Trim()))
                        {
                            if (Cell != "")
                            {
                                if (SArray == 0)
                                {
                                    CodeArray = new String[1];
                                    CodeArray[0] = Cell;
                                }
                                else
                                {
                                    OldCodeArray = new String[SArray];
                                    for (int j = 0; j < SArray; j++)
                                        OldCodeArray[j] = CodeArray[j];
                                    CodeArray = new String[SArray + 1];
                                    for (int j = 0; j < SArray; j++)
                                        CodeArray[j] = OldCodeArray[j];
                                    CodeArray[SArray] = Cell;
                                }
                                Cell = "";
                                SArray++;
                            }
                        }
                        else
                        {
                            Cell += Str.Trim() + "\n";
                        }
                        Str = "";
                    }
                    else
                    {
                        Str += ch.ToString();
                    }
                }
                else
                {
                    if (IsConjuction(Str.Trim()) == false)
                    {
                        Cell += Str.Trim() + "\n";
                    }
                    if (Cell != "")
                    {
                        if (SArray == 0)
                        {
                            CodeArray = new String[1];
                            CodeArray[0] = Cell;
                        }
                        else
                        {
                            OldCodeArray = new String[SArray];
                            for (int j = 0; j < SArray; j++)
                                OldCodeArray[j] = CodeArray[j];
                            CodeArray = new String[SArray + 1];
                            for (int j = 0; j < SArray; j++)
                                CodeArray[j] = OldCodeArray[j];
                            CodeArray[SArray] = Cell;
                        }
                        SArray++;
                    }
                }
            }

            return CodeArray;
        }
/// <summary>
/// This Function recognizes the conjoction keywords
/// </summary>
/// <param name="Str">The text that you want to check it</param>
/// <returns>Is Conjuction</returns>       
        private Boolean IsConjuction(String Str)
        {
            Str = Str.Trim();
            Str = Str.ToLower();
            if ((Str == "if") || (Str == "else") || (Str == "while") || (Str == "end") || (Str == "begin") || (Str == "break"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
/// <summary>
/// This function calculates Code Dependence Degree between two cells
/// </summary>
/// <param name="Cell1">A Cell of the first Algorithm Array</param>
/// <param name="Cell2">A Cell of the second Algorithm Array</param>
/// <returns>Code Dependence Degree</returns>
        private Double CDD(String Cell1, String Cell2)
        {
            String tcache = "";

            Cell1 = RemoveNullLine(Cell1);
            Cell2 = RemoveNullLine(Cell2);           
            String[] Sym1 = new String[CountLine(Cell1)];
            String[] Sym2 = new String[CountLine(Cell2)];
            
            int j = 0;
            for (int i = 0; i < Cell1.Length; i++)
            {
                if (Cell1[i] == '\n')
                {
                    if (tcache.Trim() != "")
                    {
                        Sym1[j++] = tcache; 
                        tcache = "";
                    }
                }
                else
                {
                    tcache += Cell1[i];
                }
            }
            if (tcache.Trim() != "")
            {
                Sym1[j++] = tcache;
            }
            
            tcache = "";
            j = 0;
            for (int i = 0; i < Cell2.Length; i++)
            {
                if (Cell2[i] == '\n')
                {
                    if (tcache.Trim() != "")
                    {
                        Sym2[j++] = tcache;
                        tcache = "";
                    }
                }
                else
                {
                    tcache += Cell2[i];
                }
            }
            if (tcache.Trim() != "")
            {
                Sym2[j++] = tcache;
            }
            int Count = 0;
            foreach (String str1 in Sym1)
            {               
                foreach (String str2 in Sym2)
                {
                    if (str1.ToLower() == str2.ToLower())
                    {
                        Count++;
                        break;
                    }
                }                
            }
            int MSymbole = (CountLine(Cell1) < CountLine(Cell2)) ? CountLine(Cell2) : CountLine(Cell1);

            return ((Double)(Count)) / ((Double)(MSymbole));
        }
/// <summary>
/// This function check null lines in each cell
/// </summary>
/// <param name="txt">Symbols in Cell</param>
/// <returns>Modified Symbols without null lines</returns>
        private String RemoveNullLine(String txt)
        {
            String RetText = "", tcache = "";           
            
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '\n')
                {
                    if (tcache.Trim() != "")
                    {
                        RetText += tcache + "\n";
                        tcache = "";
                    }
                }
                else
                {
                    tcache += txt[i];
                }
            }
            if (tcache.Trim() != "")
            {
                RetText += tcache + "\n";
            }

            return RetText;
        }
/// <summary>
/// This function counts the symbols in cell
/// </summary>
/// <param name="txt">Cell</param>
/// <returns>Number of symbols</returns>
        private int CountLine(String txt)
        {           
            int line = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '\n') line++;
            }
            return line;
        }

        private void btnCgC2toC1_Click(object sender, EventArgs e)
        {
            rtCode2.Text = rtCode1.Text;
        }

        private void btnCgC1toC2_Click(object sender, EventArgs e)
        {
            rtCode1.Text = rtCode2.Text;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            String Text;
            Text = rtCode1.Text;
            rtCode1.Text = rtCode2.Text;
            rtCode2.Text = Text;
        }

        private void btnCode1Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtCode1.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnCode2Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtCode2.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnCode1Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "CAIL Code (*.cail) | *.cail";
            sf.FilterIndex = 1;
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtCode1.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnCode2Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "CAIL Code (*.cail) | *.cail";
            sf.FilterIndex = 1;
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtCode2.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
            }
        }


    }
}
