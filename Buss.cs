namespace Sõidukite_liidese_ul;

public class Buss : ISõiduk
{
    public double KütusekuluLiitrites { get; set; }
    public double VahemaaKm { get; set; }
    public int ReisijateArv { get; set; }

    public Buss(double kütusekuluLiitrites, double vahemaaKm, int reisijateArv)
    {
        KütusekuluLiitrites = kütusekuluLiitrites;
        VahemaaKm = vahemaaKm;
        ReisijateArv = reisijateArv;
    }

    public double ArvutaKulu() => ReisijateArv > 0 ? (VahemaaKm * KütusekuluLiitrites / 100) / ReisijateArv : 0;
    public double ArvutaVahemaa() => VahemaaKm;

    public override string ToString()
    {
        return $"Buss – Reisijad: {ReisijateArv}, Kulu per inimene: {ArvutaKulu():F2} l, Vahemaa: {ArvutaVahemaa()} km";
    }
}

