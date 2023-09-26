using System.Xml.Serialization;
using System;
using System.Text.RegularExpressions;

namespace TaupymoPlanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(AgeTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Įvesti galima tik skaičius.");
                AgeTextBox.Text = AgeTextBox.Text.Remove(AgeTextBox.Text.Length - 1);
            }
        }

        private void RevenueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(RevenueTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Įvesti galima tik skaičius.");
                RevenueTextBox.Text = RevenueTextBox.Text.Remove(RevenueTextBox.Text.Length - 1);
            }
        }

        

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CalculateButton_Click(object sender, EventArgs e)
        {  
            

            if (AgeTextBox.Text == "" || RevenueTextBox.Text == ""  || GenderBox.Text == "" || PensionFundTextbox.Text == "")
            {
                MessageBox.Show("Užpildykite visus laukus");
            }
            else
            {

                double RevenueText;
                RevenueText = int.Parse(RevenueTextBox.Text);
                int PensionFund;
                PensionFund = int.Parse(PensionFundTextbox.Text);
                int Age;
                Age = int.Parse(AgeTextBox.Text);
                int PensionAge = 65;
                


                if (GenderBox.Text == "Moteris")
                {
                    int RemainingAge = PensionAge - Age;
                    int RemainingAgeMonths = RemainingAge * 12;
                    double ExpectedPension = RevenueText * 0.70;
                    double CurrentValue = ExpectedPension - PensionFund;
                    ;
                    double YearsAfterInflation = CurrentValue * Math.Pow((1 + (0.03 % 100)), RemainingAge);
                    
                    

                    double Result = (YearsAfterInflation * 180) / (RemainingAge * 12);

                    double RecommendedSavings = YearsAfterInflation * 180;

                    ResultBox.Text = Result.ToString();
                    RecommendedPension.Text = RecommendedSavings.ToString();
                }
                else if (GenderBox.Text == "Vyras")
                {
                    int RemainingAge = PensionAge - Age;
                    int RemainingAgeMonths = RemainingAge * 12;
                    double ExpectedPension = RevenueText * 0.70;
                    double CurrentValue = ExpectedPension - PensionFund;

                    double YearsAfterInflation = CurrentValue * Math.Pow((1 + (0.03 % 100)), RemainingAge);
                    
                    double RecommendedSavings = YearsAfterInflation * 60;

                    double Result = (YearsAfterInflation * 60) / (RemainingAge * 12);
                    

                    ResultBox.Text = Result.ToString();
                    RecommendedPension.Text = RecommendedSavings.ToString();
                }
               
            }


            
        }

        private void PensionFundTextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PensionFundTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Įvesti galima tik skaičius.");
                PensionFundTextbox.Text = PensionFundTextbox.Text.Remove(PensionFundTextbox.Text.Length - 1);
            }
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RecommendedPension_TextChanged(object sender, EventArgs e)
        {

        }
    }
}