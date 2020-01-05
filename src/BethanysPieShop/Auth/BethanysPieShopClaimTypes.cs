using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BethanysPieShop.Auth
{
    public static class BethanysPieShopClaimTypes
    {
        public static List<string> ClaimsList { get; set; } = new List<string> { "Delete Pie", "Add Pie", "Age for ordering" };

        public  static  void TestMethod()
        {
            try
            {
                ClaimsList = new List<string>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
