using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignments_1_ASP_
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                imgProduct.Visible = false;
                Price.Visible = false;
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            Price.Visible = true;
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProduct = int.Parse(ddlProducts.SelectedValue);


            imgProduct.Visible = false;
            Price.Visible = false;


            switch (selectedProduct)
            {
                case 1:
                    imgProduct.ImageUrl = "product_images/book.jpg";
                    Price.Text = "Price: 2000 RS";
                    break;
                case 2:
                    imgProduct.ImageUrl = "product_images/pen.jpg";
                    Price.Text = "Price: 150 RS";
                    break;
                case 3:
                    imgProduct.ImageUrl = "product_images/bag.jpg";
                    Price.Text = "Price: 600RS";
                    break;
                case 4:
                    imgProduct.ImageUrl = "product_images/shoes.jpg";
                    Price.Text = "Price: 2000 RS";
                    break;
                default:
                    imgProduct.Visible = false;
                    Price.Visible = false;
                    break;
            }


            if (selectedProduct != 0)
            {
                imgProduct.Visible = true;
            }
        }
    }
}