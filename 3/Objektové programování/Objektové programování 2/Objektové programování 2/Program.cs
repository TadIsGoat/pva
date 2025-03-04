using Objektové_programování_2;
/*
Auto subaUwU = new Auto("černé", 300, "wrx", 189);
Auto quatro = new Auto("bílé", 600, "hillclimb edition", 267);
Auto miata = new Auto("růžové", 270, "coupé", 175);

//subaUwU.barva = "černá";
subaUwU.JedHodinu();
subaUwU.JedHodinu();
miata.JedHodinu();
quatro.JedHodinu();
subaUwU.infomarceOAutu(subaUwU);
miata.infomarceOAutu(miata);
quatro.infomarceOAutu(quatro);
*/

Auto[] auta = new Auto[]
{
    new Auto("černé", 300, "wrx", 189),
    new Auto("bílé", 600, "hillclimb edition", 267),
    new Auto("růžové", 270, "coupé", 175)
};

foreach (Auto auto in auta)
    auto.JedHodinu();

foreach (Auto auto in auta)
    auto.infomarceOAutu(auto);