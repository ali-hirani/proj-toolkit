using System;
using System.Diagnostics;

class TipCalculator
{
    public double billTotal;
    //billValue
    public double billNum;
    //pre-tax bill value
    public string billParse;
    public double tipRate = -1;
    public double tipValue = 0;
    public double custTipRate = -1;
    ConsoleKeyInfo serviceKey;
    public void TipCalc()
    {
        Console.WriteLine("This tool calculates the Tip based on quality of service.");
        Console.WriteLine("How was the service today?");
        Console.WriteLine("");
        Console.WriteLine("1. Excellent!");
        //20% tip
        Console.WriteLine("2. Good");
        //15% tip
        Console.WriteLine("3. Okay");
        //10% tip
        Console.WriteLine("4. Poor");
        //0% tip
        Console.WriteLine("5. Custom");
        //Custom tip amount
        Console.WriteLine("");
        do
        {
            serviceKey = Console.ReadKey();
            if(serviceKey.KeyChar == '1')
            {
                tipRate = 0.2;
            }
            else if(serviceKey.KeyChar == '2')
            {
                tipRate = 0.15;
            }
            else if(serviceKey.KeyChar == '3')
            {
                tipRate = 0.1;
            }
            else if(serviceKey.KeyChar == '4')
            {
                tipRate = 0;
            }
            else if(serviceKey.KeyChar == '5')
            {   
                Console.WriteLine("---Accepted");
                Console.WriteLine("Please enter a custom tip amount in percent.");
                Console.WriteLine();
                custTipRate = (Double.Parse(Console.ReadLine()))/100;

            }
            else
            {
                Console.WriteLine("---Not Accepted");
                Console.WriteLine();
                Console.WriteLine("Choose from options 1 to 5.");
                Console.WriteLine();
            }
        }
        while(tipRate < 0 && custTipRate < 0);
        //if its set to any of the 4 rates, or the custRate, it will exit the loop
        
        if(tipRate >= 0)
        //for formatting purposes
        {
            Console.WriteLine("---Accepted");
            Console.WriteLine("");
        }
        else if(custTipRate > 0)
        //for formatting purposes
        {
            Console.WriteLine("");
        }
        
        Console.WriteLine("Enter Pre-tax Bill Value.");    
        do
        {
            Console.WriteLine("");
            billParse = Console.ReadLine();
            if(double.TryParse(billParse, out billNum))
            {
                if(tipRate >= 0)
                {
                    tipValue = billNum * tipRate;
                    //tip is evaluated on pretax value
                    billTotal = (tipValue + billNum * 1.13);
                    //total = tip + bill pretax + tax
                    Console.WriteLine("");
                    Console.WriteLine("You should tip: ${0:f2}", tipValue);
                    Console.WriteLine("Your total comes to: ${0:f2} including tax.", billTotal);
                }
                if(custTipRate > 0)
                {
                    tipValue = billNum * custTipRate;
                    //tip is evaluated on pretax value
                    billTotal = (tipValue + billNum * 1.13);
                    //total = tip + bill pretax + tax
                    Console.WriteLine("");
                    Console.WriteLine("You should tip: ${0:f2}", tipValue);
                    Console.WriteLine("Your total comes to: ${0:f2} including tax. ", billTotal);
                }
            }
            else
            {
                Console.WriteLine("Please input valid number.");
                //if it does not parse as a dobule, request valid input
            }
        }
        while(tipValue == 0);
        //exits loop if the the entered value is a numerical value
    }
}
class Statistic
{
    public double sum;
    //holds total sum of numerical values inputted
    public double sumNum;
    //contains the value read in
    public string sumParse;
    //string for ReadLine() for TryParse
    public void Sum()
    //yields the sum of a set of user inputted number
    {
        Console.WriteLine("This tool calculates the sum of numbers inputted. Enter each value individually and type end to terminate input.");
        do
        {
            sumParse = Console.ReadLine();
            if(double.TryParse(sumParse, out sumNum))
            //checks if the string sumParse parses as a double
            {

                sum += sumNum;
                //if it does parse as double, output to sumNum which is then added to sum
            }
            else if(sumParse == "end")
            {
                Console.WriteLine("");
                Console.Write("The Sum of the Inputted Values is: ");
            }
            else
            {
                Console.WriteLine("Please input valid number.");
                //if it does not parse as a dobule, request valid input
            }
        }
        while(sumParse != "end");
        //user must type end to terminate the program
        Console.Write(sum);
        sum = 0;
        //resets value so that if the sum function is used again in the same function it wont be additive
    }
}
class Element
{
    private string chemFormula;
    private string [] nameBase = {"Helium", "Lithium", "Beryllium", "Boron", "Carbon", "Nitrogen", "Oxygen", "Fluorine", "Neon", "Sodium", "Magnesium", "Aluminium", "Silicon", "Phosphorus", "Sulfur", "Chlorine", "Argon", "Potassium", "Calcium", "Scandium", "Titanium", "Vanadium", "Chromium", "Manganese", "Iron", "Cobalt", "Nickel", "Copper", "Zinc", "Gallium", "Germanium", "Arsenic", "Selenium", "Bromine", "Krypton", "Rubidium", "Strontium", "Yttrium", "Zirconium", "Niobium", "Molybdenum", "Technetium", "Ruthenium", "Rhodium", "Palladium", "Silver", "Cadmium", "Indium", "Tin", "Antimony", "Tellurium", "Iodine", "Xenon", "Cesium", "Barium", "Lanthanum", "Cerium", "Praseodymium", "Neodymium", "Promethium", "Samarium", "Europium", "Gadolinium", "Terbium", "Dysprosium", "Holmium", "Erbium", "Thulium", "Ytterbium", "Lutetium", "Hafnium", "Tantalum", "Tungsten", "Rhenium", "Osmium", "Iridium", "Platinum", "Gold", "Mercury", "Thallium", "Lead", "Bismuth", "Polonium", "Astatine", "Radon", "Francium", "Radium", "Actinium", "Thorium", "Protactinium", "Uranium", "Neptunium", "Plutonium", "Americium", "Curium", "Berkelium", "Californium", "Einsteinium", "Fermium", "Mendelevium", "Nobelium", "Lawrencium", "Rutherfordium", "Dubnium", "Seaborgium", "Bohrium", "Hassium", "Meitnerium", "Darmstadtium", "Roentgenium", "Copernicium", "Ununtrium", "Ununquadium", "Ununpentium", "Ununhexium", "Ununseptium", "Ununoctium"};
    private double [] molarMassBase = {4.002602,6.941,9.012182,10.811,12.0107,14.0067,15.9994,18.9984032,20.1797,22.98976928,24.305,26.9815386,28.0855,30.973762,32.065,35.453,39.948,39.0983,40.078,44.955912,47.867,50.9415,51.9961,54.938045,55.845,58.933195,58.6934,63.546,65.39,69.723,72.64,74.9216,78.96,79.904,83.798,85.4678,87.62,88.90585,91.224,92.90638,95.94,97.9072,101.07,102.90550,106.42,107.8682,112.411,114.818,118.71,121.76,127.6,126.90447,131.293,132.9054519,137.327,138.90547,140.116,140.90765,144.242,144.9127,150.36,151.964,157.25,158.92535,162.5,164.93032,167.259,168.93421,173.04,174.967,178.49,180.94788,183.84,186.207,190.23,192.217,195.084,196.966569,200.59,204.3833,207.2,208.9804,208.9824,209.9871,222.0176,223.0197,226.0254,227.0277,232.03806,231.03588,238.02891,237.0482,244.0642,243.0614,247.0704,247.0703,251.0796,252.0830,257.0951,258.0984,259.1010,262.1097,261.1088,262,266,264,277,268,271,272,285,284,289,288,292,0,294};

    private int atoms;
    //represents # of atoms of an element ex: H_2 = 2 
    public Element(string chemFormula)
    {
        this.chemFormula = chemFormula;
    }
    public string ChemFormula
    {
        get
        {
            return chemFormula;
        }
    }
    public int Atoms
    {   
        get
        {
            return atoms;
        }
        set
        {
            atoms = value;
        }
    }
    public void ChemName()
    {
        string tmp = chemFormula;
        switch(tmp)
        {
            case "H": Console.Write("Hydrogen");
            break;
            case "He": Console.Write(nameBase[0]);
            break;
            case "Li": Console.Write(nameBase[1]);
            break;
            case "Be": Console.Write(nameBase[2]);
            break;
            case "B": Console.Write(nameBase[3]);
            break;
            case "C": Console.Write(nameBase[4]);
            break;
            case "N": Console.Write(nameBase[5]);
            break;
            case "O": Console.Write(nameBase[6]);
            break;
            case "F": Console.Write(nameBase[7]);
            break;
            case "Ne": Console.Write(nameBase[8]);
            break;
            case "Na": Console.Write(nameBase[9]);
            break;
            case "Mg": Console.Write(nameBase[10]);
            break;
            case "Al": Console.Write(nameBase[11]);
            break;
            case "Si": Console.Write(nameBase[12]);
            break;
            case "P": Console.Write(nameBase[13]);
            break;
            case "S": Console.Write(nameBase[14]);
            break;
            case "Cl": Console.Write(nameBase[15]);
            break;
            case "Ar": Console.Write(nameBase[16]);
            break;
            case "K": Console.Write(nameBase[17]);
            break;
            case "Ca": Console.Write(nameBase[18]);
            break;
            case "Sc": Console.Write(nameBase[19]);
            break;
            case "Ti": Console.Write(nameBase[20]);
            break;
            case "V": Console.Write(nameBase[21]);
            break;
            case "Cr": Console.Write(nameBase[22]);
            break;
            case "Mn": Console.Write(nameBase[23]);
            break;
            case "Fe": Console.Write(nameBase[24]);
            break;
            case "Co": Console.Write(nameBase[25]);
            break;
            case "Ni": Console.Write(nameBase[26]);
            break;
            case "Cu": Console.Write(nameBase[27]);
            break;
            case "Zn": Console.Write(nameBase[28]);
            break;
            case "Ga": Console.Write(nameBase[29]);
            break;
            case "Ge": Console.Write(nameBase[30]);
            break;
            case "As": Console.Write(nameBase[31]);
            break;
            case "Se": Console.Write(nameBase[32]);
            break;
            case "Br": Console.Write(nameBase[33]);
            break;
            case "Kr": Console.Write(nameBase[34]);
            break;
            case "Rb": Console.Write(nameBase[35]);
            break;
            case "Sr": Console.Write(nameBase[36]);
            break;
            case "Y": Console.Write(nameBase[37]);
            break;
            case "Zr": Console.Write(nameBase[38]);
            break;
            case "Nb": Console.Write(nameBase[39]);
            break;
            case "Mo": Console.Write(nameBase[40]);
            break;
            case "Tc": Console.Write(nameBase[41]);
            break;
            case "Ru": Console.Write(nameBase[42]);
            break;
            case "Rh": Console.Write(nameBase[43]);
            break;
            case "Pd": Console.Write(nameBase[44]);
            break;
            case "Ag": Console.Write(nameBase[45]);
            break;
            case "Cd": Console.Write(nameBase[46]);
            break;
            case "In": Console.Write(nameBase[47]);
            break;
            case "Sn": Console.Write(nameBase[48]);
            break;
            case "Sb": Console.Write(nameBase[49]);
            break;
            case "Te": Console.Write(nameBase[50]);
            break;
            case "I": Console.Write(nameBase[51]);
            break;
            case "Xe": Console.Write(nameBase[52]);
            break;
            case "Cs": Console.Write(nameBase[53]);
            break;
            case "Ba": Console.Write(nameBase[54]);
            break;
            case "La": Console.Write(nameBase[55]);
            break;
            case "Ce": Console.Write(nameBase[56]);
            break;
            case "Pr": Console.Write(nameBase[57]);
            break;
            case "Nd": Console.Write(nameBase[58]);
            break;
            case "Pm": Console.Write(nameBase[59]);
            break;
            case "Sm": Console.Write(nameBase[60]);
            break;
            case "Eu": Console.Write(nameBase[61]);
            break;
            case "Gd": Console.Write(nameBase[62]);
            break;
            case "Tb": Console.Write(nameBase[63]);
            break;
            case "Dy": Console.Write(nameBase[64]);
            break;
            case "Ho": Console.Write(nameBase[65]);
            break;
            case "Er": Console.Write(nameBase[66]);
            break;
            case "Tm": Console.Write(nameBase[67]);
            break;
            case "Yb": Console.Write(nameBase[68]);
            break;
            case "Lu": Console.Write(nameBase[69]);
            break;
            case "Hf": Console.Write(nameBase[70]);
            break;
            case "Ta": Console.Write(nameBase[71]);
            break;
            case "W": Console.Write(nameBase[72]);
            break;
            case "Re": Console.Write(nameBase[73]);
            break;
            case "Os": Console.Write(nameBase[74]);
            break;
            case "Ir": Console.Write(nameBase[75]);
            break;
            case "Pt": Console.Write(nameBase[76]);
            break;
            case "Au": Console.Write(nameBase[77]);
            break;
            case "Hg": Console.Write(nameBase[78]);
            break;
            case "Tl": Console.Write(nameBase[79]);
            break;
            case "Pb": Console.Write(nameBase[80]);
            break;
            case "Bi": Console.Write(nameBase[81]);
            break;
            case "Po": Console.Write(nameBase[82]);
            break;
            case "At": Console.Write(nameBase[83]);
            break;
            case "Rn": Console.Write(nameBase[84]);
            break;
            case "Fr": Console.Write(nameBase[85]);
            break;
            case "Ra": Console.Write(nameBase[86]);
            break;
            case "Ac": Console.Write(nameBase[87]);
            break;
            case "Th": Console.Write(nameBase[88]);
            break;
            case "Pa": Console.Write(nameBase[89]);
            break;
            case "U": Console.Write(nameBase[90]);
            break;
            case "Np": Console.Write(nameBase[91]);
            break;
            case "Pu": Console.Write(nameBase[92]);
            break;
            case "Am": Console.Write(nameBase[93]);
            break;
            case "Cm": Console.Write(nameBase[94]);
            break;
            case "Bk": Console.Write(nameBase[95]);
            break;
            case "Cf": Console.Write(nameBase[96]);
            break;
            case "Es": Console.Write(nameBase[97]);
            break;
            case "Fm": Console.Write(nameBase[98]);
            break;
            case "Md": Console.Write(nameBase[99]);
            break;
            case "No": Console.Write(nameBase[100]);
            break;
            case "Lr": Console.Write(nameBase[101]);
            break;
            case "Rf": Console.Write(nameBase[102]);
            break;
            case "Db": Console.Write(nameBase[103]);
            break;
            case "Sg": Console.Write(nameBase[104]);
            break;
            case "Bh": Console.Write(nameBase[105]);
            break;
            case "Hs": Console.Write(nameBase[106]);
            break;
            case "Mt": Console.Write(nameBase[107]);
            break;
            case "Ds": Console.Write(nameBase[108]);
            break;
            case "Rg": Console.Write(nameBase[109]);
            break;
            case "Cp": Console.Write(nameBase[111]);
            break;
            case "Uut": Console.Write(nameBase[112]);
            break;
            case "Uuq": Console.Write(nameBase[113]);
            break;
            case "Uup": Console.Write(nameBase[114]);
            break;
            case "Uuh": Console.Write(nameBase[115]);
            break;
            case "Uus": Console.Write(nameBase[116]);
            break;
            case "Uuo": Console.Write(nameBase[117]);
            break;
            default: Console.Write("Invalid Element Formula");
            break;
        }
    }
    public double MolarMass()
    {
        int numAtom = atoms;
        string tmp = chemFormula;
        double mMass = 0;
        switch(tmp)
        {
            case "H": mMass = 1.00794;
            break;
            case "He": mMass = (molarMassBase[0]);
            break;
            case "Li": mMass = (molarMassBase[1]);
            break;
            case "Be": mMass = (molarMassBase[2]);
            break;
            case "B": mMass = (molarMassBase[3]);
            break;
            case "C": mMass = (molarMassBase[4]);
            break;
            case "N": mMass = (molarMassBase[5]);
            break;
            case "O": mMass = (molarMassBase[6]);
            break;
            case "F": mMass = (molarMassBase[7]);
            break;
            case "Ne": mMass = (molarMassBase[8]);
            break;
            case "Na": mMass = (molarMassBase[9]);
            break;
            case "Mg": mMass = (molarMassBase[10]);
            break;
            case "Al": mMass = (molarMassBase[11]);
            break;
            case "Si": mMass = (molarMassBase[12]);
            break;
            case "P": mMass = (molarMassBase[13]);
            break;
            case "S": mMass = (molarMassBase[14]);
            break;
            case "Cl": mMass = (molarMassBase[15]);
            break;
            case "Ar": mMass = (molarMassBase[16]);
            break;
            case "K": mMass = (molarMassBase[17]);
            break;
            case "Ca": mMass = (molarMassBase[18]);
            break;
            case "Sc": mMass = (molarMassBase[19]);
            break;
            case "Ti": mMass = (molarMassBase[20]);
            break;
            case "V": mMass = (molarMassBase[21]);
            break;
            case "Cr": mMass = (molarMassBase[22]);
            break;
            case "Mn": mMass = (molarMassBase[23]);
            break;
            case "Fe": mMass = (molarMassBase[24]);
            break;
            case "Co": mMass = (molarMassBase[25]);
            break;
            case "Ni": mMass = (molarMassBase[26]);
            break;
            case "Cu": mMass = (molarMassBase[27]);
            break;
            case "Zn": mMass = (molarMassBase[28]);
            break;
            case "Ga": mMass = (molarMassBase[29]);
            break;
            case "Ge": mMass = (molarMassBase[30]);
            break;
            case "As": mMass = (molarMassBase[31]);
            break;
            case "Se": mMass = (molarMassBase[32]);
            break;
            case "Br": mMass = (molarMassBase[33]);
            break;
            case "Kr": mMass = (molarMassBase[34]);
            break;
            case "Rb": mMass = (molarMassBase[35]);
            break;
            case "Sr": mMass = (molarMassBase[36]);
            break;
            case "Y": mMass = (molarMassBase[37]);
            break;
            case "Zr": mMass = (molarMassBase[38]);
            break;
            case "Nb": mMass = (molarMassBase[39]);
            break;
            case "Mo": mMass = (molarMassBase[40]);
            break;
            case "Tc": mMass = (molarMassBase[41]);
            break;
            case "Ru": mMass = (molarMassBase[42]);
            break;
            case "Rh": mMass = (molarMassBase[43]);
            break;
            case "Pd": mMass = (molarMassBase[44]);
            break;
            case "Ag": mMass = (molarMassBase[45]);
            break;
            case "Cd": mMass = (molarMassBase[46]);
            break;
            case "In": mMass = (molarMassBase[47]);
            break;
            case "Sn": mMass = (molarMassBase[48]);
            break;
            case "Sb": mMass = (molarMassBase[49]);
            break;
            case "Te": mMass = (molarMassBase[50]);
            break;
            case "I": mMass = (molarMassBase[51]);
            break;
            case "Xe": mMass = (molarMassBase[52]);
            break;
            case "Cs": mMass = (molarMassBase[53]);
            break;
            case "Ba": mMass = (molarMassBase[54]);
            break;
            case "La": mMass = (molarMassBase[55]);
            break;
            case "Ce": mMass = (molarMassBase[56]);
            break;
            case "Pr": mMass = (molarMassBase[57]);
            break;
            case "Nd": mMass = (molarMassBase[58]);
            break;
            case "Pm": mMass = (molarMassBase[59]);
            break;
            case "Sm": mMass = (molarMassBase[60]);
            break;
            case "Eu": mMass = (molarMassBase[61]);
            break;
            case "Gd": mMass = (molarMassBase[62]);
            break;
            case "Tb": mMass = (molarMassBase[63]);
            break;
            case "Dy": mMass = (molarMassBase[64]);
            break;
            case "Ho": mMass = (molarMassBase[65]);
            break;
            case "Er": mMass = (molarMassBase[66]);
            break;
            case "Tm": mMass = (molarMassBase[67]);
            break;
            case "Yb": mMass = (molarMassBase[68]);
            break;
            case "Lu": mMass = (molarMassBase[69]);
            break;
            case "Hf": mMass = (molarMassBase[70]);
            break;
            case "Ta": mMass = (molarMassBase[71]);
            break;
            case "W": mMass = (molarMassBase[72]);
            break;
            case "Re": mMass = (molarMassBase[73]);
            break;
            case "Os": mMass = (molarMassBase[74]);
            break;
            case "Ir": mMass = (molarMassBase[75]);
            break;
            case "Pt": mMass = (molarMassBase[76]);
            break;
            case "Au": mMass = (molarMassBase[77]);
            break;
            case "Hg": mMass = (molarMassBase[78]);
            break;
            case "Tl": mMass = (molarMassBase[79]);
            break;
            case "Pb": mMass = (molarMassBase[80]);
            break;
            case "Bi": mMass = (molarMassBase[81]);
            break;
            case "Po": mMass = (molarMassBase[82]);
            break;
            case "At": mMass = (molarMassBase[83]);
            break;
            case "Rn": mMass = (molarMassBase[84]);
            break;
            case "Fr": mMass = (molarMassBase[85]);
            break;
            case "Ra": mMass = (molarMassBase[86]);
            break;
            case "Ac": mMass = (molarMassBase[87]);
            break;
            case "Th": mMass = (molarMassBase[88]);
            break;
            case "Pa": mMass = (molarMassBase[89]);
            break;
            case "U": mMass = (molarMassBase[90]);
            break;
            case "Np": mMass = (molarMassBase[91]);
            break;
            case "Pu": mMass = (molarMassBase[92]);
            break;
            case "Am": mMass = (molarMassBase[93]);
            break;
            case "Cm": mMass = (molarMassBase[94]);
            break;
            case "Bk": mMass = (molarMassBase[95]);
            break;
            case "Cf": mMass = (molarMassBase[96]);
            break;
            case "Es": mMass = (molarMassBase[97]);
            break;
            case "Fm": mMass = (molarMassBase[98]);
            break;
            case "Md": mMass = (molarMassBase[99]);
            break;
            case "No": mMass = (molarMassBase[100]);
            break;
            case "Lr": mMass = (molarMassBase[101]);
            break;
            case "Rf": mMass = (molarMassBase[102]);
            break;
            case "Db": mMass = (molarMassBase[103]);
            break;
            case "Sg": mMass = (molarMassBase[104]);
            break;
            case "Bh": mMass = (molarMassBase[105]);
            break;
            case "Hs": mMass = (molarMassBase[106]);
            break;
            case "Mt": mMass = (molarMassBase[107]);
            break;
            case "Ds": mMass = (molarMassBase[108]);
            break;
            case "Rg": mMass = (molarMassBase[109]);
            break;
            case "Cp": mMass = (molarMassBase[111]);
            break;
            case "Uut": mMass = (molarMassBase[112]);
            break;
            case "Uuq": mMass = (molarMassBase[113]);
            break;
            case "Uup": mMass = (molarMassBase[114]);
            break;
            case "Uuh": mMass = (molarMassBase[115]);
            break;
            case "Uus": mMass = (molarMassBase[116]);
            break;
            case "Uuo": mMass = (molarMassBase[117]);
            break;
            
        }
        mMass *= numAtom;
        return mMass;
    }
}
class Qformula
{
//(b^2) - 4ac < 0 then it can't do anything
    public double a = 0;
    public double b= 0;
    public double c= 0;
    public double test= 0;
    public double result1= 0; 
    public double result2= 0;
	
	public void Quadformula()
	{
        Console.WriteLine("Welcome to the Quadratic Calculator.");

        do
        {
            Console.WriteLine("Please enter the A value.");
            a = Double.Parse(Console.ReadLine());
        	Console.WriteLine("Please enter the B value.");
        	b  = Double.Parse(Console.ReadLine());
        	Console.WriteLine("Please enter the C value.");
        	c = Double.Parse(Console.ReadLine());
            test = (b * b) - (4*(a * c));
            if(test < 0)
            {
                Console.WriteLine("Value is not real.");
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
		while (test < 0);
		result1 = (-b + Math.Sqrt((b * b) - (4 * (a * c)))) / (2 * (a));
		result2 =(-b - Math.Sqrt((b * b) - (4 * (a * c)))) / (2 * (a));
			
		Console.WriteLine("x1 = " + Math.Round(result1, 3));
		Console.WriteLine("x2 = " + Math.Round(result2, 3));	
	}		
}
class RandomNumberGen
{
    public int rn = 0;
    public void Rando(int Rmin, int Rmax)
    {
       Random rn = new Random();
       Console.WriteLine("Your Randomly Generated Number Within the Bounds is: " + rn.Next(Rmin, Rmax + 1)); 
       //Rmax + 1 makes it inclusive of the user's inputs
       //Therefore Rmin = 5, Rmax = 6 can yield 5 or 6
    }
}
/*class Timer
{
    //public Stopwatch stopwatch = new Stopwatch();
    ConsoleKeyInfo watchKey;
    public void StopTimer()
    {
        do
        {
            stopwatch.Start();
            Console.Write("\r{0}", stopwatch.Elapsed);
        }
        while(watchKey.KeyChar != 's');
        stopwatch.Stop();
    }
*/
//}
class UserInterface
{

    public void EmptyMethod(string toolName)
    {
        Console.WriteLine("---Accepted");
        Console.WriteLine("");
        Console.WriteLine("You chose {0}", toolName);
        Console.WriteLine("");
        Console.WriteLine("{0} not implemented", toolName);
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadKey();
    }
    public void ToolStart(string toolName)
    {
        Console.WriteLine("---Accepted");
        Console.WriteLine("");
        Console.WriteLine("You chose {0}", toolName);
        Console.WriteLine("");
    }
    public void ToolEnd()
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadKey();
    }
}
class Program
{
    static void Main()
    {
        UserInterface ui = new UserInterface();
        TipCalculator tc = new TipCalculator();
        Statistic stat = new Statistic();
		Qformula qf = new Qformula();
        RandomNumberGen rng = new RandomNumberGen();

        DateTime now = DateTime.Now;
        //Stopwatch stopwatch = new Stopwatch();

        ConsoleKeyInfo uiKey;
        bool keyCheck = false;
        bool terminate = false;
        string tool1 = "Tip Calculator".PadRight(29);
        string tool2 = "Quadratic Formula".PadRight(29);
        string tool3 = "Mean/Mode/Median Tool".PadRight(29);
        string tool4 = "Sum Tool".PadRight(29);
        string tool5 = "Molar Mass Calculator".PadRight(29);
        string tool6 = "Element Name Tool".PadRight(29);
        string tool7 = "Random Number Generator".PadRight(29);
        
        while(terminate == false)
        //terminate's value only changes in the else if condition where 't' is pressed
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Choose the tool you want to use!");
                Console.WriteLine("--------------------------------");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. {0}", tool1);
                Console.WriteLine("2. {0}", tool2);
                Console.WriteLine("3. {0}", tool3);
                Console.WriteLine("4. {0}", tool4);
                Console.WriteLine("5. {0}", tool5);
                Console.WriteLine("6. {0}", tool6);
                Console.WriteLine("7. {0}", tool7);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Press t to Terminate Program    ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Session Start Date/Time: " + now);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("");
                uiKey = Console.ReadKey();
                if(uiKey.KeyChar == '1')
                {
                    ui.ToolStart(tool1);
                    tc.TipCalc();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '2')
                {
                    ui.ToolStart(tool2);
					qf.Quadformula();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '3')
                {
                    ui.EmptyMethod(tool3);
                    keyCheck = true;
                }
                else if(uiKey.KeyChar == '4')
                {
                    ui.ToolStart(tool4);
                    stat.Sum();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '5')
                {
                    ui.ToolStart(tool5);
                    double molarMassSum = 0;
                    keyCheck = true;
                    Console.WriteLine("");
                    Console.WriteLine("How many elements are present in the molecule?");
                    Console.WriteLine("");
                    int elNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    for(int i = 1; i <= elNum; i++)
                    {
                        Console.WriteLine("Input chemical formula for element #{0} in molecule:",i);
                        Console.WriteLine("");
                        Element userElement = new Element(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Input number of atoms of element #{0} in molecule:",i);
                        Console.WriteLine("");
                        userElement.Atoms = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        molarMassSum += userElement.MolarMass();
                    }
                    Console.WriteLine("Molar Mass = {0}", molarMassSum);
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '6')
                {
                    ui.ToolStart(tool6);
                    keyCheck = true;
                    Console.WriteLine("Type in Chemical Formula");
                    Console.WriteLine("");
                    Element userElement= new Element(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Chemical Name: ");
                    userElement.ChemName();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '7')
                {
                    ui.ToolStart(tool7);
                    Console.WriteLine("Enter Lower Bound.");
                    Console.WriteLine("");
                    int RminMain = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Enter Upper Bound.");
                    Console.WriteLine("");
                    int RmaxMain = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    rng.Rando(RminMain, RmaxMain);
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == 't')
                {
                    Console.WriteLine("---Accepted");
                    Console.WriteLine("");
                    Console.WriteLine("You chose to exit");
                    keyCheck = true;
                    terminate = true;
                    //terminate is only true if t is pressed, the while loop is exited
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("---Not Accepted");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to main menu");
                    Console.ReadKey();
                }
            }
            while(keyCheck == false);
        }
        Console.WriteLine("---------------------");
        Console.WriteLine("Press Any Key to Exit");
        Console.ReadKey();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Session End Date/Time: " + DateTime.Now);
        Console.WriteLine("------------------------------------------------");
    }
}