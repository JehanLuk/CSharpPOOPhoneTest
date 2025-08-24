using Models;

Iphone i1 = new Iphone(number: "119974347", model: "Iphone 15", imei: "111111111111111", memory: 8);
Nokia n1 = new Nokia(number: "119974456", model: "Nokia 6", imei: "111333111111111", memory: 6);

i1.Call();
i1.InstallApp("Instagram");

n1.Call();
n1.InstallApp("Facebook");