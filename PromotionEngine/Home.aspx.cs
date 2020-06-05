using System;
using System.Data;
using System.Linq;

namespace PromotionEngine
{
    public partial class Home : System.Web.UI.Page
    {
        private int Sum, BalanceQTY;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddSKU();
                DataTable dtSKUTable = (DataTable)ViewState["SKUTable"];
                GridView1.DataSource = dtSKUTable;
                GridView1.DataBind();

                AddPromo();
                DataTable dtOfferTable = (DataTable)ViewState["OfferTable"];
                GridView2.DataSource = dtOfferTable;
                GridView2.DataBind();
            }
        }

        // To Add some some of SKU data
        public void AddSKU()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("SKU"), new DataColumn("Price") });
            // add SKU A
            DataRow dr;
            dr = dt.NewRow();
            dr["SKU"] = "A";
            dr["Price"] = "50";
            dt.Rows.Add(dr);
            // add SKU B
            dr = dt.NewRow();
            dr["SKU"] = "B";
            dr["Price"] = "30";
            dt.Rows.Add(dr);
            // add SKU C
            dr = dt.NewRow();
            dr["SKU"] = "C";
            dr["Price"] = "20";
            dt.Rows.Add(dr);
            // add SKU D
            dr = dt.NewRow();
            dr["SKU"] = "D";
            dr["Price"] = "15";
            dt.Rows.Add(dr);

            ViewState["SKUTable"] = dt;
        }

        // To Add some some of Offers
        public void AddPromo()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("PromoID"), new DataColumn("Description"), new DataColumn("SKU"), new DataColumn("QTY"), new DataColumn("Offer") });
            // Offer 1 - SKU A
            DataRow dr;
            dr = dt.NewRow();
            dr["PromoID"] = "1";
            dr["Description"] = "3 of A's for 130";
            dr["SKU"] = "A";
            dr["QTY"] = "3";
            dr["Offer"] = "130";
            dt.Rows.Add(dr);
            // Offer 2 - SKU B
            dr = dt.NewRow();
            dr["PromoID"] = "2";
            dr["Description"] = "2 of B's for 45";
            dr["SKU"] = "B";
            dr["QTY"] = "2";
            dr["Offer"] = "45";
            dt.Rows.Add(dr);
            // Offer 3 - SKU C
            dr = dt.NewRow();
            dr["PromoID"] = "3";
            dr["Description"] = "C & D for 30";
            dr["SKU"] = "C";
            dr["QTY"] = "1";
            dr["Offer"] = "20";
            dt.Rows.Add(dr);
            // Offer 4 - SKU D
            dr = dt.NewRow();
            dr["PromoID"] = "4";
            dr["Description"] = "C & D for 30";
            dr["SKU"] = "D";
            dr["QTY"] = "1";
            dr["Offer"] = "30";
            dt.Rows.Add(dr);


            ViewState["OfferTable"] = dt;
        }

        // Text on changes process
        protected void _txtSKU_TextChanged(object sender, EventArgs e)
        {
            DataTable dtSKUTable = (DataTable)ViewState["SKUTable"];

            // First Product Offer - A SKU
            if (_txtSKU1.Text != "" && _txtQTY1.Text != "")
            {
                DataRow drSKU = dtSKUTable.Select("SKU = '" + _txtSKU1.Text + "'").FirstOrDefault();
                if (drSKU != null)
                {
                    _lblPrice1.Text = drSKU["Price"].ToString();

                    _lblValue1.Text = CheckOffer(_txtSKU1.Text, _txtQTY1.Text, _lblPrice1.Text).ToString();
                }
                DataTable dtOfferTable = (DataTable)ViewState["OfferTable"];
                DataRow drOffer = dtOfferTable.Select("SKU = '" + _txtSKU1.Text + "' and QTY <= '" + _txtQTY1.Text + "'").FirstOrDefault();
                if (drOffer != null)
                {
                    _lblOffer1.Text = drOffer["Description"].ToString();
                }
            }

            // Second Product Offer - B SKU
            if (_txtSKU2.Text != "" && _txtQTY2.Text != "")
            {
                DataRow drSKU = dtSKUTable.Select("SKU = '" + _txtSKU2.Text + "'").FirstOrDefault();
                if (drSKU != null)
                {
                    _lblPrice2.Text = drSKU["Price"].ToString();

                    _lblValue2.Text = CheckOffer(_txtSKU2.Text, _txtQTY2.Text, _lblPrice2.Text).ToString();
                }
                DataTable dtOfferTable = (DataTable)ViewState["OfferTable"];
                DataRow drOffer = dtOfferTable.Select("SKU = '" + _txtSKU2.Text + "' and QTY <= '" + _txtQTY2.Text + "'").FirstOrDefault();
                if (drOffer != null)
                {
                    _lblOffer2.Text = drOffer["Description"].ToString();
                }
            }

            // Third Product Offer - C SKU
            if (_txtSKU3.Text != "" && _txtQTY3.Text != "")
            {
                DataTable dtOfferTable = (DataTable)ViewState["OfferTable"];
                DataRow drOffer = dtOfferTable.Select("SKU = '" + _txtSKU3.Text + "' and QTY <= '" + _txtQTY3.Text + "'").FirstOrDefault();
                if (drOffer != null)
                {
                    DataRow drSKU = dtSKUTable.Select("SKU = '" + _txtSKU3.Text + "'").FirstOrDefault();
                    if (drSKU != null)
                    {
                        _lblPrice3.Text = drSKU["Price"].ToString();

                        if (_txtSKU3.Text == "C" || _txtSKU4.Text == "C")
                        {
                            _lblValue3.Text = CheckOffer(_txtSKU3.Text, _txtQTY3.Text, _lblPrice3.Text).ToString();
                        }
                    }
                }
            }

            // Fourth Product Offer - D SKU
            if (_txtSKU4.Text != "" && _txtQTY4.Text != "")
            {
                DataTable dtOfferTable = (DataTable)ViewState["OfferTable"];
                DataRow drOffer = dtOfferTable.Select("SKU = '" + _txtSKU4.Text + "' and QTY <= '" + _txtQTY4.Text + "'").FirstOrDefault();
                if (drOffer != null)
                {
                    _lblOffer4.Text = drOffer["Description"].ToString();

                    DataRow drSKU = dtSKUTable.Select("SKU = '" + _txtSKU4.Text + "'").FirstOrDefault();
                    if (drSKU != null)
                    {
                        _lblPrice4.Text = drSKU["Price"].ToString();
                        if (_txtQTY3.Text == "1" && _txtQTY4.Text == "1")
                        {
                            _lblValue3.Text = "0";
                        }

                        if (_txtSKU3.Text == "C" || _txtSKU4.Text == "C")
                        {
                            if (_txtSKU3.Text == "D" || _txtSKU4.Text == "D")
                            {
                                int BalanceQTY, Sum;
                                BalanceQTY = Convert.ToInt16(_txtQTY4.Text) - Convert.ToInt16(drOffer["QTY"].ToString());
                                Sum = 30 + BalanceQTY * Convert.ToInt16(_lblPrice4.Text);

                                _lblValue4.Text = Sum.ToString();

                            }
                        }
                    }
                }
            }

            _lblTotal.Text = (Convert.ToInt16(_lblValue1.Text) + Convert.ToInt16(_lblValue2.Text) + Convert.ToInt16(_lblValue3.Text) + Convert.ToInt16(_lblValue4.Text)).ToString();
        }

        protected void _btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        // Checking Current Promotion
        public int CheckOffer(string SKU, string QTY, string Print)
        {
            Sum = 0; BalanceQTY = 0;
            DataTable dtOfferTable = (DataTable)ViewState["OfferTable"];
            DataRow dr = dtOfferTable.Select("SKU = '" + SKU + "' and QTY <= '" + QTY + "'").FirstOrDefault();
            if (dr != null)
            {
                if (SKU == "A")
                {
                    return Scenario.ScenarioA(Convert.ToInt32(QTY), Convert.ToInt16(dr["QTY"].ToString()), Convert.ToInt32(dr["Offer"].ToString()), Convert.ToInt32(Print));
                }
                else if (SKU == "B")
                {
                    return Scenario.ScenarioB(Convert.ToInt32(QTY), Convert.ToInt16(dr["QTY"].ToString()), Convert.ToInt32(dr["Offer"].ToString()), Convert.ToInt32(Print), Sum);
                }
                else if (SKU == "C")
                {
                    Sum = Convert.ToInt32(QTY) * Convert.ToInt32(Print);
                    return Sum;
                }
                else if (SKU == "D")
                {
                    return Sum;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                int Sum = Convert.ToInt32(QTY) * Convert.ToInt32(Print);
                return Sum;
            }
        }
    }
}