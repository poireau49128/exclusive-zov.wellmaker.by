﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zovprofil.zovprofil.Controls
{
    public partial class ProductItem : System.Web.UI.UserControl
    {
        public string Name = "";
        public string ProductImageUrl = "";
        public string URL = "";
        public string FrontColor = Catalog.ExclusiveFontColor;

        protected void Page_Load(object sender, EventArgs e)
        {
            ProdImage.Src = ProductImageUrl;
            ProdCategory.InnerHtml = Name;
            Link.HRef = URL;
            if (!URL.Contains("Эксклюзив"))
                FrontColor = Catalog.notExclusiveFontColor;
            ProdCategory.Style["color"] = FrontColor;
        }
    }
}