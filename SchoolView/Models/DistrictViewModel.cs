using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolView.Models
{
    public class DistrictViewModel
    {
        public SelectList Districts { get; set; }
        public string SelectedDistrict { get; set; }
        public List<District> districtList { get; set; }

        //public string DistrictInformation { get; set; }
    }
}