namespace MAUI_Sample_Proyects.Perfect_Pay;

public partial class PerfectPay : ContentPage
{
    decimal bill;
    int tip;
    int noPersons = 1;



    public PerfectPay()
    {
        InitializeComponent();
    }

    private void txtBill_Completed(object sender, EventArgs e)
    {
        bill = decimal.Parse(txtBill.Text);
        CalculateTotal();
    }

    private void CalculateTotal()
    {
        //Total tip
        var totalTip = bill * tip / 100;

        //Tip by person
        var tipbyPerson = totalTip / noPersons;
        lblTipByPerson.Text = $"{tipbyPerson:C}";

        //Subtotal
        var subTotal = bill / noPersons;
        lblSubtotal.Text = $"{subTotal:C}";

        //Total
        var totalbyPerson = (bill + totalTip) / noPersons;
        lblTotal.Text = $"{totalbyPerson:C}";
    }

    private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        tip = (int)sldTip.Value;
        lblTip.Text = $"Tip: {tip}%";
        CalculateTotal();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is Button)
        {
            var btn = (Button)sender;
            var percentage = int.Parse(btn.Text.Replace("%", ""));
            sldTip.Value = percentage;
        }
    }

    private void btnMinus_Clicked(object sender, EventArgs e)
    {
        if (noPersons > 1)
        {
            noPersons--;
            lblNoPersons.Text = noPersons.ToString();
            CalculateTotal();
        }
    }

    private void btnPlus_Clicked(object sender, EventArgs e)
    {
        noPersons++;
        lblNoPersons.Text = noPersons.ToString();
        CalculateTotal();
    }
}