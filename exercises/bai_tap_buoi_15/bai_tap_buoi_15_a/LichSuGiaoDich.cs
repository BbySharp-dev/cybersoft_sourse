using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class LichSuGiaoDich
{
    private List<string> lichSu = new List<string>();

    public void LuuGiaoDich(string giaoDich)
    {
        lichSu.Add(giaoDich);
        File.WriteAllText("lich_su_giao_dich.json", JsonConvert.SerializeObject(lichSu, Formatting.Indented));
    }

    public void HienThiLichSu()
    {
        if (File.Exists("lich_su_giao_dich.json"))
        {
            lichSu = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("lich_su_giao_dich.json"));
            Console.WriteLine("\n===== Lịch sử giao dịch =====");
            foreach (var gd in lichSu)
            {
                Console.WriteLine(gd);
            }
        }
        else
        {
            Console.WriteLine("Không có lịch sử giao dịch.");
        }
    }
}
