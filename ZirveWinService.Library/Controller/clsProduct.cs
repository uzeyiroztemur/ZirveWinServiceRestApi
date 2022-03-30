using System;
using System.Collections.Generic;
using Zirve503Lib;
using ZirveWinService.Library.Helpers;
using ZirveWinService.Library.Models;

namespace ZirveWinService.Library.Controller
{
    public static class clsProduct
    {
        public static ReturnData<bool> Save(ProductPostModel data)
        {
            ReturnData<bool> result = new ReturnData<bool>();
            try
            {
                var conObject = ZirveHelper.GetConnectionObject();

                List<Stok> StokListeler = new List<Stok>();

                Stok CKart = new Stok(conObject);
                CKart.set_KartKodu(data.Code);
                CKart.set_KartAdi(data.Name);
                CKart.set_Birim(data.Unit);

                StokListeler.Add(CKart);

                CbkIslem cbkIslem = new CbkIslem(conObject);
                cbkIslem.set_EklenecekStokKartlar(StokListeler);

                if (cbkIslem.StokKartiKaydet())
                {
                    result.Data = true;
                    result.Status = ReturnStatus.Success;
                    result.Message = "OK";
                }
                else
                {
                    result.Data = false;
                    result.Status = ReturnStatus.Error;
                    result.Message = cbkIslem.get_HataMesaji();
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Error($"clsProduct.Save() -> {ex}");

                result.Status = ReturnStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
