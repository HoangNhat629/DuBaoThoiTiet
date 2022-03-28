
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Filters;
using System;
using System.Data;
namespace C45
{
    [SerializableAttribute]
    public class C45_Learning
    {
        DataTable dataHuanLuyen = new DataTable();
        Codification codebook;
        DataTable symbols;
        DecisionTree thuattoanC45;
        
        string[] inputColumns = { "DK1", "DK2" };
        string outputColumn = "output";

        public C45_Learning()
        {


        }
        string[] columnNames = { "DK1", "DK2", "Output" };
        string[][] data =
             {
                new string[] { "1", "1", "0"},
                new string[] { "1", "2", "0"},
                new string[] { "2", "3", "1"},
                new string[] { "3", "4", "1"},
                new string[] { "4", "0", "2"},
                new string[] { "5", "0", "3"},
                new string[] { "6", "0", "4"},
                new string[] { "7", "0", "5"}
            };
        public void ThuatToan()
        {
            // Create a new codification codebook to
            // convert strings into discrete symbols
            Codification codebook = new Codification(columnNames, data);

            // Extract input and output pairs to train
            int[][] symbols = codebook.Transform(data);
            int[][] inputs = symbols.Get(null, 0, -1); // Gets all rows, from 0 to the last (but not the last)
            int[] outputs = symbols.GetColumn(-1);     // Gets only the last column

            // Create the C45  
            var teacher = new C45Learning();

            // Estimate the model using the data
           thuattoanC45 = teacher.Learn(inputs, outputs);
            
        }

        [Obsolete]
        public void ThuatToanC45(string[] pColumns, DataTable pDataHuanLuyen, string[] pinputColumns, string poutputColumn)
        {
            dataHuanLuyen= pDataHuanLuyen;
            inputColumns = pinputColumns;
            outputColumn = poutputColumn;


            codebook = new Codification(dataHuanLuyen, pColumns);
            symbols = codebook.Apply(dataHuanLuyen);
            int[][] inputs = symbols.ToArray<int>(pinputColumns);
            int[] outputs = symbols.ToArray<int>(poutputColumn);

            // Create the C45  
            var teacher = new C45Learning();

            // Estimate the model using the data
            thuattoanC45 = teacher.Learn(inputs, outputs);

        }
        [Obsolete]
        public  string KetQua(string[] pInput)
        {
            try
            {
                string[] columntest = inputColumns;

                string[] valuetest = new string[pInput.Length];

                int[] instance = codebook.Translate(columntest, pInput);
                
                int c = thuattoanC45.Compute(instance);

                string result = codebook.Translate(outputColumn, c);

                return result;
            }
            catch
            {
                return "Khac";
            }
        }
        public string doiso(string pVaule)
        {
            if (pVaule == "0")
                return "0.0";
            if (pVaule == "1")
                return "1.0";
            if (pVaule == "2")
                return "2.0";
            if (pVaule == "3")
                return "3.0";
            if (pVaule == "4")
                return "4.0";
            if (pVaule == "5")
                return "5.0";
            if (pVaule == "6")
                return "6.0";
            if (pVaule == "7")
                return "7.0";
            if (pVaule == "8")
                return "8.0";
            if (pVaule == "9")
                return "9.0";
            if (pVaule == "10")
                return "10.0";

            return pVaule;
        }

    }
}
