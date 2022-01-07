// DRY - Do not reapead yourself
// Loop - dongu
// Debug
// CTRL + K + C
/*var ad = "MuradEli";*/

//for(var i =0; i < 5; i++)
//{
//    Console.WriteLine(ad);
//}


//var reqem = 5;

//var reqem1 = 0;

//while (reqem != reqem1)
//{
//    Console.WriteLine(ad);

//    reqem1++;
//}

// multi dimensional - 2d,3d,4d,5d



//string[] telebeler = {
//    "MuradEli", "Gunel","Resad","Vahid"
//};

//string[] telebeler2 = {
//    "Bagirzade", "Ibrahimova","Rustemli","Muradov"
//};

//for (int i = 0; i < telebeler.Length; i++)
//{
//    Console.WriteLine(telebeler[i] + " " + telebeler2[i]);
//}

string[,] telebeInfo = {
    { "MehemmedEli", "Bagirzade" },//[0][0] 
    { "Gunel","Ibrahimova"} // [1][0]
};



for (int i = 0; i < telebeInfo.Length; i++)
{
    Console.WriteLine(telebeInfo[0,i]);
}

