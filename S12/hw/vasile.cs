public interface Ivasile
{
    public string NameFunc();
    public int sandali();
    public int Tier();
    public bool use_gasoline_benzin();


}

class car:Ivasile
{
    public string cname ;
    public int tiers;
    public int sandalis ;
    public bool use_benzin_or_no;

    public car(string Ncname,int Tier , int sandali , bool use_gasoline_benzin)
    {
        cname = Ncname ;
        tiers = Tier ;
        sandalis = sandali;
        use_benzin_or_no = use_gasoline_benzin;
    }


    public int Tier()
    {
        return tiers ;
    }

    public int sandali()
    {
        return sandalis ;

    }

    public bool use_gasoline_benzin()
    {
        return use_benzin_or_no ;
    }

    public string NameFunc()
    {
        return cname ;
    }


    
}


class bus:Ivasile
{
    public string name;
    public int bus_tiers;
    public int bus_sandalis ;
    public bool bus_use_benzin_or_no;
    public bus(string Nname,int Nbus_tiers , int Nbus_sandalis , bool Nbus_use_benzin_or_no)
    {
        name = Nname ;
        bus_tiers = Nbus_tiers ;
        bus_sandalis = Nbus_sandalis;
        bus_use_benzin_or_no = Nbus_use_benzin_or_no;
    }

    public int Tier()
    {
        return bus_tiers;
    }

    public int sandali()
    {
        return bus_sandalis;
    }

    public bool use_gasoline_benzin()
    {
        return bus_use_benzin_or_no;
    }

    public string NameFunc()
    {
        return name ;
    }

}

class bicycle : Ivasile
{
    public string bice_name;
    public int bice_tiers;
    public int bice_sandalis;
    public bool bice_use_benzin_or_no;

    public bicycle(string BNname, int BNtiers, int BNsandalis, bool BNuse_benzin_or_no)
    {
        bice_name = BNname;
        bice_tiers = BNtiers;
        bice_sandalis = BNsandalis;
        bice_use_benzin_or_no = BNuse_benzin_or_no;
    }

    public int Tier()
    {
        return bice_tiers;
    }

    public int sandali()
    {
        return bice_sandalis;
    }

    public bool use_gasoline_benzin()
    {
        return bice_use_benzin_or_no;
    }

    public string NameFunc()
    {
        return bice_name;
    }
}