using DoorBoxApp.Data;
using DoorBoxApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models
{
    public class Tarrif
    {
        public int Id { get; set; }

        public int PackageCatagoryId { get; set; }
        public PackageCatagory PackageCatagory { get; set; }

        public int LocationFromId { get; set; }
        public Location LocationFrom { get; set; }
        public int LocationToId { get; set; }
        public Location LocationTo { get; set; }


        public double Weight { get; set; }

        public double FixedAmountFirstKG { get; set; }

        public double IncrementPerKG { get; set; }

        public int Status { get; set; }

        public static TarrifPriceViewModel GetDesiredTarrif(int merchantId,int catagoryId, int locationFromId, int locationToId, double weight, ApplicationDbContext _context)
        {
            var tarrifMerchant = _context.MerchantTarrifs.Where(m => m.PackageCatagoryId == catagoryId && m.LocationFromId == locationFromId && m.LocationToId == locationToId && m.Status==1 && m.MerchantId==merchantId).FirstOrDefault();

            if (tarrifMerchant!=null)
            {
                TarrifPriceViewModel tarrifPVM = new TarrifPriceViewModel();

                //if (tarrif==null)
                //{
                //     tarrif = _context.Tarrifs.Where(m => m.PackageCatagoryId == catagoryId && m.LocationFromId == locationFromId && m.LocationToId == locationToId).FirstOrDefault();
                //}



                if (tarrifMerchant != null)
                {
                    tarrifPVM.MerchantTarrif = tarrifMerchant;
                    tarrifPVM.MerchantTarrifId = tarrifMerchant.Id;
                    if (weight < 1)
                    {
                        tarrifPVM.ExtraweightPrice = 0;
                        tarrifPVM.TotalPrice = tarrifMerchant.FixedAmountFirstKG;
                    }
                    else
                    {
                        int extraWeight = (int)weight - 1;
                        tarrifPVM.ExtraweightPrice = extraWeight * tarrifMerchant.IncrementPerKG;
                        tarrifPVM.TotalPrice = tarrifMerchant.FixedAmountFirstKG + tarrifPVM.ExtraweightPrice;


                    }
                    return tarrifPVM;


                }
                else
                {
                    return null;
                }
            }

            else
            {
                var tarrif = _context.Tarrifs.Where(m => m.PackageCatagoryId == catagoryId && m.LocationFromId == locationFromId && m.LocationToId == locationToId && m.Status == 1).FirstOrDefault();


                TarrifPriceViewModel tarrifPVM = new TarrifPriceViewModel();

                //if (tarrif==null)
                //{
                //     tarrif = _context.Tarrifs.Where(m => m.PackageCatagoryId == catagoryId && m.LocationFromId == locationFromId && m.LocationToId == locationToId).FirstOrDefault();
                //}



                if (tarrif != null)
                {
                    tarrifPVM.Tarrif = tarrif;
                    tarrifPVM.TarrifId = tarrif.Id;
                    if (weight < 1)
                    {
                        tarrifPVM.ExtraweightPrice = 0;
                        tarrifPVM.TotalPrice = tarrif.FixedAmountFirstKG;
                    }
                    else
                    {
                        int extraWeight = (int)weight - 1;
                        tarrifPVM.ExtraweightPrice = extraWeight * tarrif.IncrementPerKG;
                        tarrifPVM.TotalPrice = tarrif.FixedAmountFirstKG + tarrifPVM.ExtraweightPrice;


                    }
                    return tarrifPVM;


                }
                else
                {
                    return null;
                }
            }



           
            
        }

    }
}
