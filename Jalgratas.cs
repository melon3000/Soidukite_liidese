namespace Sõidukite_liidese_ul;

public class Jalgratas : ISõiduk
{
    public double VahemaaKm { get; set; }

    public Jalgratas(double vahemaaKm)
    {
        VahemaaKm = vahemaaKm;
    }

    public double ArvutaKulu() => 0;
    public double ArvutaVahemaa() => VahemaaKm; 

    public override string ToString()
    {
        return $"Jalgratas – Kulu: {ArvutaKulu()} l, Vahemaa: {ArvutaVahemaa()} km";
    }
}
