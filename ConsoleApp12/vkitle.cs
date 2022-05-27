using System;

public class Class1
{
	public Class1()
	{
        void vkitle()
        {
            Console.WriteLine("BOY:");
            double x = dstr();
            Console.WriteLine("KİLO:");
            double y = dstr();
            double vucut_kitle = (y / (x * x));
            vucut_kitle = Math.Round(vucut_kitle, 2);
            double ideal_kg = (x * x * 20);

            if (vucut_kitle <= 18.5)
            {
                Console.WriteLine("BOYUNUZ " + x + "M KİLONUZ" + y + "KG VÜCÜT KİTLE İNDEKSİ " + vucut_kitle + " ZAYİFSİNİZ" + " İDEAL KİLONUZ:" + ideal_kg);
            }
            else if (vucut_kitle <= 24.9 && vucut_kitle > 18.5)
            {
                Console.WriteLine("BOYUNUZ " + x + "M KİLONUZ" + y + "KG VÜCÜT KİTLE İNDEKSİ" + vucut_kitle + " NORMAL" + " İDEAL KİLONUZ:" + ideal_kg);
            }
            else if (vucut_kitle <= 29.9 && vucut_kitle >= 24.9)
            {
                Console.WriteLine("BOYUNUZ " + x + "M KİLONUZ" + y + "KG VÜCÜT KİTLE İNDEKSİ" + vucut_kitle + " FAZLA KİLOLU" + " İDEAL KİLONUZ:" + ideal_kg);
            }
            else if (vucut_kitle <= 34.9 && vucut_kitle > 29.9)
            {
                Console.WriteLine("BOYUNUZ " + x + "M KİLONUZ" + y + "KG VÜCÜT KİTLE İNDEKSİ" + vucut_kitle + " I.DERECE OBEZ" + " İDEAL KİLONUZ:" + ideal_kg);
            }
            else if (vucut_kitle <= 39.9 && vucut_kitle > 34.9)
            {
                Console.WriteLine("BOYUNUZ " + x + "M KİLONUZ" + y + "KG VÜCÜT KİTLE İNDEKSİ" + vucut_kitle + " II.DERECE OBEZ" + " İDEAL KİLONUZ:" + ideal_kg);
            }
            else
            {
                Console.WriteLine("BOYUNUZ " + x + "M KİLONUZ" + y + "KG VÜCÜT KİTLE İNDEKSİ" + vucut_kitle + " III.DERECE OBEZ" + " İDEAL KİLONUZ:" + ideal_kg);

            }
        }
    }
}
