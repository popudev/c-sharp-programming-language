// See https://aka.ms/new-console-template for more information
using week3;

MonLyThuyet monLyThuyet = new MonLyThuyet("01", "Toan", 5, "IT", 0,9,9,8);
MonThucHanh monThucHanh = new MonThucHanh("02", "Toan", 5, "IT", 0,9,9,8,8);
MonDoAn mon = new MonDoAn("03","Toan",5,"IT",0,9,9);
SinhVien sinhvien = new SinhVien(monLyThuyet, monThucHanh,mon);
/*mon.TinhDiem();*/
Console.WriteLine(Math.Round(sinhvien.DiemTichLuy(),2));
Console.WriteLine(monLyThuyet.TinhDiem());
Console.WriteLine(monThucHanh.TinhDiem());
Console.WriteLine(mon.TinhDiem());