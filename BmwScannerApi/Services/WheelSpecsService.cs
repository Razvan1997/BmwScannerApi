using BmwScannerApi.Models;

namespace BmwScannerApi.Services
{
    public static class WheelsSpecsService
    {
        public static Task<List<WheelSpecs>> GetData()
        {
            List<WheelSpecs> wheelSpecs = new List<WheelSpecs>
{
	//style 2
	new WheelSpecs
    {
        WheelStyleName = "style 2",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 2",
        Series = "6er E24",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 2",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
	//style 3
	new WheelSpecs
    {
        WheelStyleName = "style 3",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "7,62"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 3",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "7,62"
    },
	
	
	
	//style 4
	new WheelSpecs
    {
        WheelStyleName = "style 4",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "6,65"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 4",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "6,65"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 4",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x16",
        Use = "",
        ET = "ET 23",
        Kg = "8,19"
    },
	
	
	//style 5
	new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "3er E30",
        Model = "",
        Except = "M3",
        Size = "6,5x14",
        Use = "",
        ET = "ET 30",
        Kg = "6,35"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "3er E30",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 24",
        Kg = "7,38"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "3er E30",
        Model = "325ix",
        Except = "",
        Size = "6,5x14",
        Use = "",
        ET = "ET 45",
        Kg = "6,92"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "3er E30",
        Model = "325ix",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 41",
        Kg = "7,68"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "3er E30",
        Model = "M3",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 30",
        Kg = "7,26"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "3er E30",
        Model = "M3",
        Except = "",
        Size = "7,5x16",
        Use = "",
        ET = "ET 27",
        Kg = "8,22"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "3er E36",
        Model = "",
        Except = "Touring, M3",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "5er E28",
        Model = "",
        Except = "",
        Size = "7x14",
        Use = "",
        ET = "ET 18",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "5er E28",
        Model = "M5",
        Except = "",
        Size = "7,5x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7,5x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "6er E24",
        Model = "",
        Except = "",
        Size = "7x14",
        Use = "",
        ET = "ET 18",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "6er E24",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "7er E23",
        Model = "",
        Except = "",
        Size = "7x14",
        Use = "",
        ET = "ET 18",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 5",
        Series = "Z1",
        Model = "",
        Except = "",
        Size = "7x15 ****",
        Use = "",
        ET = "",
        Kg = ""
    },
	
	
	
	//style 6
	new WheelSpecs
    {
        WheelStyleName = "style 6",
        Series = "3er E36",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,80"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 6",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,80"
    },
	
	
	
	//style 7
	new WheelSpecs
    {
        WheelStyleName = "style 7",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "390x180TD",
        Use = "",
        ET = "ET 19",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 7",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "390x180TD",
        Use = "",
        ET = "ET 19",
        Kg = ""
    },
	
	
	
	//style 8
	new WheelSpecs
    {
        WheelStyleName = "style 8",
        Series = "8er E31",
        Model = "",
        Except = "CSi",
        Size = "7,5x16",
        Use = "",
        ET = "ET 15",
        Kg = ""
    },
	
	
	
	//style 9
	new WheelSpecs
    {
        WheelStyleName = "style 9",
        Series = "8er E31",
        Model = "",
        Except = "CSi",
        Size = "7,5x16",
        Use = "",
        ET = "ET 15",
        Kg = ""
    },
	
	
	
	//style 10
	new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "3er E30",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 24",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "3er E36",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 22",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 10",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = ""
    },
	
	
	//style 11
	new WheelSpecs
    {
        WheelStyleName = "style 11",
        Series = "Z1",
        Model = "",
        Except = "",
        Size = "4x15",
        Use = "",
        ET = "ET 25",
        Kg = "5,92"
    },
	
	
	
	//style 13
	new WheelSpecs
    {
        WheelStyleName = "style 13",
        Series = "3er E36",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
	
	
	
	//style 14
	new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "3er E36",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 22",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 14",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = ""
    },
	
	
	//style 15
	new WheelSpecs
    {
        WheelStyleName = "style 15",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "7,5x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
	
	
	//style 16
	new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "3er E36",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "11,66"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 22",
        Kg = "12,25"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "11,63"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "11,63"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = "11,92"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 16",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
	
	
	//style 17
	new WheelSpecs
    {
        WheelStyleName = "style 17",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 17",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 45",
        Kg = ""
    },
	
	
	
	//style 18
	new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "3er E36",
        Model = "",
        Except = "328i, M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "8,65"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,33"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,80"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "12,00"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "3er E46",
        Model = "316i - 320",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "8,65"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,33"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "8,83"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = "10,65"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "11,70"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "11,70"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 22",
        Kg = "11,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E39",
        Model = "520, 525",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "8,83"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E39",
        Model = "",
        Except = "V8, M5",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "8,83"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = "10,46"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "12,39"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "12,39"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = "12,18"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "7,5x16",
        Use = "",
        ET = "ET 20",
        Kg = "10,68"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "Z3 E36",
        Model = "Roadster 1.8 / 1.9",
        Except = "M",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "8,65"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,33"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "M",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,80"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 18",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "M",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "12,00"
    },
	
	
	
	//style 19
	new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "9,46"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "9,48"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "9,48"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 22",
        Kg = "9,75"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "9,78"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "9,78"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = "	9,60"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 19",
        Series = "Z3 E36",
        Model = "Roadster 1.8 / 1.9",
        Except = "M",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "9,46"
    },
	
	
	
	//style 20
	new WheelSpecs
    {
        WheelStyleName = "style 20",
        Series = "5er E34",
        Model = "",
        Except = "V8",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 20",
        Series = "5er E34",
        Model = "",
        Except = "V8",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 20",
        Series = "5er E34",
        Model = "",
        Except = "V8",
        Size = "9x17",
        Use = "back",
        ET = "ET 22",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 20",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 20",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = ""
    },
	
	
	
	//style 21
	new WheelSpecs
    {
        WheelStyleName = "style 21",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17 *",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 21",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17 *",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 21",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x17 *",
        Use = "back",
        ET = "ET 22",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 21",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 21",
        Series = "7er E32",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = ""
    },

    new WheelSpecs
    {
        WheelStyleName = "style 21",
        Series = "8er E31",
        Model = "",
        Except = "",
        Size = "8x17 *",
        Use = "front",
        ET = "ET 10",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 21",
        Series = "8er E31",
        Model = "",
        Except = "",
        Size = "9x17 *",
        Use = "back",
        ET = "ET 19",
        Kg = ""
    },	
	
	
	//style 22
	new WheelSpecs
    {
        WheelStyleName = "style 22",
        Series = "3er E36",
        Model = "",
        Except = "Touring",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "9,68"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 22",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M Roadster",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "9,68"
    },
	
	
	//style 23
	new WheelSpecs
    {
        WheelStyleName = "style 23",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,13"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 23",
        Series = "3er E36",
        Model = "",
        Except = "",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,13"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 23",
        Series = "3er E36",
        Model = "",
        Except = "",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,65"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 23",
        Series = "3er E36",
        Model = "M3",
        Except = "",
        Size = "7x17 *",
        Use = "",
        ET = "ET 41",
        Kg = "10,00"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 23",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,13"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 23",
        Series = "Z3 E36",
        Model = "",
        Except = "",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,13"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 23",
        Series = "Z3 E36",
        Model = "",
        Except = "",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,65"
    },			

	
	//style 24
	new WheelSpecs
    {
        WheelStyleName = "style 24",
        Series = "3er E36",
        Model = "",
        Except = "Compact",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "8,94"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 24",
        Series = "3er E36",
        Model = "",
        Except = "Compact",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "9,48"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 24",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "1.8 / 1.9, M",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "8,94"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 24",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "1.8 / 1.9, M",
        Size = "8,5x17",
        Use = "back	",
        ET = "ET 41",
        Kg = "9,48"
    },	
	
	
	
	//style 25
	new WheelSpecs
    {
        WheelStyleName = "style 25",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "8,36"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 25",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "8,36"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 25",
        Series = "5er E39",
        Model = "",
        Except = "",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = "9,32"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 25",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x16",
        Use = "",
        ET = "ET 23",
        Kg = "12,00"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 25",
        Series = "Z3 E36",
        Model = "Roadster,Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "8,36"
    },
	
	
	

	//style 26
	new WheelSpecs
    {
        WheelStyleName = "style 26",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,31"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 26",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,31"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 26",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "10,96"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 26",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "10,96"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 26",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 22",
        Kg = "11,00"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 26",
        Series = "Z3 E36",
        Model = "Roadster/Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,31"
    },
	
	
	//style 27
	new WheelSpecs
    {
        WheelStyleName = "style 27",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,52"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 27",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,52"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 27",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,52"
    },
	
	
	
	//style 28
	new WheelSpecs
    {
        WheelStyleName = "style 28",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,68"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 28",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,68"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 28",
        Series = "3er E46",
        Model = "Roadster 1.8/1.9",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,68"
    },
	//style 29
	new WheelSpecs
    {
        WheelStyleName = "style 29",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 29",
        Series = "3er E46",
        Model = "316i - 323i",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 29",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 29",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 29",
        Series = "5er E39",
        Model = "",
        Except = "V8, M5",
        Size = "7x15",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 29",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 29",
        Series = "Z3 E36",
        Model = "Roadster 1.8 / 1.9",
        Except = "M",
        Size = "7x15",
        Use = "",
        ET = "",
        Kg = ""
    },
	
	
	
	//style 30
	new WheelSpecs
    {
        WheelStyleName = "style 30",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 30",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 30",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = ""
    },	
	
	
	
	//style 31
	new WheelSpecs
    {
        WheelStyleName = "style 31",
        Series = "5er E39",
        Model = "520i-528i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "6,86"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 31",
        Series = "5er E39",
        Model = "520-528i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = "6,86"
    },
	//style 32
	new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "1er E87+",
        Model = "116",
        Except = "",
        Size = "6x16",
        Use = "",
        ET = "ET 42",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E36",
        Model = "",
        Except = "328i, M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,70"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E36",
        Model = "",
        Except = "328i, M3",
        Size = "7x15 *",
        Use = "",
        ET = "ET 47",
        Kg = "7,70"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "7,40"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17 *",
        Use = "",
        ET = "ET 41",
        Kg = "9,46"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "7,5x17 *",
        Use = "front",
        ET = "ET 41",
        Kg = "9,46"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "8,5x17 *",
        Use = "back",
        ET = "ET 41",
        Kg = "9,90"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17 *",
        Use = "",
        ET = "ET 47",
        Kg = "10,39"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "7x15 *",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16 *",
        Use = "",
        ET = "ET 46",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x17 *",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x18",
        Use = "front",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8,5x18",
        Use = "back",
        ET = "ET 50",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E90+",
        Model = "",
        Except = "330",
        Size = "7x16 **",
        Use = "",
        ET = "ET 34",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "3er E90+",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 34",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E39",
        Model = "520i-528i",
        Except = "",
        Size = "7x15 *",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "7x16 *",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17 *",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x17 *",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x17 *",
        Use = "back",
        ET = "ET 26",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x18 *",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x18 *",
        Use = "back",
        ET = "ET 24",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E60+",
        Model = "",
        Except = "4x4",
        Size = "8x18",
        Use = "",
        ET = "ET 20",
        Kg = "11,80"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E60+",
        Model = "",
        Except = "4x4",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "11,80"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "5er E60+",
        Model = "",
        Except = "4x4",
        Size = "9x18",
        Use = "back",
        ET = "ET 32",
        Kg = "11,74"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x18 *",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "9x18 *",
        Use = "back",
        ET = "ET 22",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "9x20 *",
        Use = "front",
        ET = "ET 24",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "10x20 *",
        Use = "back",
        ET = "ET 24",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M",
        Size = "7x15 *",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "Z3 E36",
        Model = "Roadster,Coupe",
        Except = "M",
        Size = "7x16 *",
        Use = "",
        ET = "ET 46",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "",
        Size = "7,5x17 *",
        Use = "",
        ET = "ET 41",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "Z3 E36",
        Model = "Roadster,Coupe",
        Except = "1.8/1.9, M",
        Size = "7,5x17 *",
        Use = "front",
        ET = "ET 41",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 32",
        Series = "Z3 E36",
        Model = "Roadster,Coupe",
        Except = "1.8/1.9, M",
        Size = "8,5x17 *",
        Use = "back",
        ET = "ET 41",
        Kg = ""
    },
	
	
	//style 33
	new WheelSpecs
    {
        WheelStyleName = "style 33",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = "8,92"
    },
	
	
	
	//style 34
	new WheelSpecs
    {
        WheelStyleName = "style 34",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "6,02"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 34",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "6,02"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 34",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "6,02"
    },
	
	
	
	
	//style 35
	new WheelSpecs
    {
        WheelStyleName = "style 35",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16 *",
        Use = "",
        ET = "ET 46",
        Kg = "8,67"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 35",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "8,67"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 35",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7x16 *",
        Use = "",
        ET = "ET 46",
        Kg = "8,67"
    },
	
	
	
	//style 36
	new WheelSpecs
    {
        WheelStyleName = "style 36",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,70"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 36",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,70"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 36",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,70"
    },
	
	
	
	//style 37
	new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "5er E34",
        Model = "M5 3,8",
        Except = "",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "10,20"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "5er E34",
        Model = "",
        Except = "",
        Size = "9x18",
        Use = "back",
        ET = "ET 22",
        Kg = "9,86"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "10,27"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x18",
        Use = "back",
        ET = "ET 24",
        Kg = "10,54"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x18",
        Use = "front",
        ET = "ET 13",
        Kg = "10,27"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "9,5x18",
        Use = "back",
        ET = "ET 25",
        Kg = "10,54"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x18 *",
        Use = "front",
        ET = "ET 13",
        Kg = "10,27"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "9,5x18 *",
        Use = "back",
        ET = "ET 25",
        Kg = "10,54"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "8er E31",
        Model = "850CSi",
        Except = "",
        Size = "8x18",
        Use = "front",
        ET = "ET 13",
        Kg = "10,27"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 37",
        Series = "8er E31",
        Model = "",
        Except = "",
        Size = "9,5x18",
        Use = "back",
        ET = "ET 25",
        Kg = "10,54"
    },
	
	
	//style 38
	new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,52"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,52"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,43"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "5er E39",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "10,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "10,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = "10,86"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "Z3 E36",
        Model = "Roadster 1.8 / 1.9",
        Except = "M",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,52"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,52"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,43"
    },
	
	
	//style 39
	new WheelSpecs
    {
        WheelStyleName = "style 39",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "9,94"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 39",
        Series = "3er E36",
        Model = "",
        Except = "Compact",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "9,94"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 39",
        Series = "3er E36",
        Model = "",
        Except = "Compact",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,39"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 38",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M Roadster",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "9,94"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 39",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "M",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "9,94"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 39",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "M",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,39"
    },
	
	
	
	//style 40
	new WheelSpecs
    {
        WheelStyleName = "style 40",
        Series = "Z3 E36",
        Model = "M Roadster/Coupe",
        Except = "",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "9,60"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 40",
        Series = "Z3 E36",
        Model = "",
        Except = "",
        Size = "9x17",
        Use = "back",
        ET = "ET 8",
        Kg = "10,99"
    },
	
	
	//style 41
	new WheelSpecs
    {
        WheelStyleName = "style 41",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,59"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 41",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,59"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 41",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M",
        Size = "7x15",
        Use = "",
        ET = "ET 47",
        Kg = "7,59"
    },
	
	
	
	//style 42
	new WheelSpecs
    {
        WheelStyleName = "style 42",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,90"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 42",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "6,5x15",
        Use = "",
        ET = "ET 42",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 42",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,90"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 42",
        Series = "Z3 E36",
        Model = "Roadster,Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,90"
    },
	
	
	//style 43
	new WheelSpecs
    {
        WheelStyleName = "style 43",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "10,36"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 43",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "10,36"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 43",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "10,36"
    },
	
	
	
	//style 44
	new WheelSpecs
    {
        WheelStyleName = "style 44",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,49"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 44",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,49"
    },
	
	
	//style 45
	new WheelSpecs
    {
        WheelStyleName = "style 45",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "10,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 45",
        Series = "Z3 E36",
        Model = "",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "10,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 45",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "10,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 45",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "10,50"
    },
	
	
	
	//style 46
	new WheelSpecs
    {
        WheelStyleName = "style 46",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "6,5x15",
        Use = "",
        ET = "ET 42",
        Kg = "6,12"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 46",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 47",
        Kg = "7,39"
    },
	
	
	
	//style 47
	new WheelSpecs
    {
        WheelStyleName = "style 47",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,33"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 47",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,36"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 47",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,33"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 47",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,36"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 47",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,33"
    },
	
	
	
	//style 48
	new WheelSpecs
    {
        WheelStyleName = "style 48",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = "9,57"
    },
	
	
	//style 49
	new WheelSpecs
    {
        WheelStyleName = "style 49",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "10,36"
    },
	
	
	//style 50
	new WheelSpecs
    {
        WheelStyleName = "style 50",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 50",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 50",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 50",
        Series = "5er E60+",
        Model = "",
        Except = "4x4",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    //style 51
    new WheelSpecs
    {
        WheelStyleName = "style 51",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 51",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
    //style 53
    new WheelSpecs
    {
        WheelStyleName = "style 53",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "6,5x15",
        Use = "",
        ET = "ET 42",
        Kg = "5,57"
    },
    //style 54
    new WheelSpecs
    {
        WheelStyleName = "style 54",
        Series = "3er E46",
        Model = "316i-323i",
        Except = "",
        Size = "6,5x15",
        Use = "",
        ET = "ET 42",
        Kg = "8,48"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 54",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 42",
        Kg = "10,12"
    },
    //style 55
    new WheelSpecs
    {
        WheelStyleName = "style 55",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,20"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 55",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,20"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 55",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "ET 46",
        Kg = "9,20"
    },
    //style 56
    new WheelSpecs
    {
        WheelStyleName = "style 56",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "7,5x17",
        Use = "",
        ET = "ET 40",
        Kg = "8,94"
    },
    //style 57
    new WheelSpecs
    {
        WheelStyleName = "style 57",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "7,5x17",
        Use = "",
        ET = "ET 40",
        Kg = "10,13"
    },
    //58
    new WheelSpecs
    {
        WheelStyleName = "style 58",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "8,5x18",
        Use = "",
        ET = "ET 48",
        Kg = "12,63"
    },
    //style 59
    new WheelSpecs
    {
        WheelStyleName = "style 59",
        Series = "Z8 E52",
        Model = "",
        Except = "",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "11,92"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 59",
        Series = "Z8 E52",
        Model = "",
        Except = "",
        Size = "9x18",
        Use = "back",
        ET = "ET 22",
        Kg = "10,27"
    },
    //style 60
    new WheelSpecs
    {
        WheelStyleName = "style 60",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "7,5x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    //style 61
    new WheelSpecs
    {
        WheelStyleName = "style 61",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "7,5x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
    //style 63
    new WheelSpecs
    {
        WheelStyleName = "style 63",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "9x19",
        Use = "front",
        ET = "ET 48",
        Kg = "18,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 63",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "10x19",
        Use = "back",
        ET = "ET 45",
        Kg = "12,63"
    },
    //style 64
    new WheelSpecs
    {
        WheelStyleName = "style 64",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 64",
        Series = "3er E36",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
    new WheelSpecs
    {
        WheelStyleName = "style 64",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
    //style 65
    new WheelSpecs
    {
        WheelStyleName = "style 65",
        Series = "5er E39",
        Model = "M5",
        Except = "",
        Size = "8x18 *",
        Use = "front",
        ET = "ET 20",
        Kg = "10,71"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 65",
        Series = "5er E39",
        Model = "M5",
        Except = "",
        Size = "9,5x18 *",
        Use = "back",
        ET = "ET 22",
        Kg = "11,60"
    },
    //style 66
    new WheelSpecs
    {
        WheelStyleName = "style 66",
        Series = "5er E39",
        Model = "",
        Except = "M5 nur Winterbereifung",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "10,39"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 66",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x17",
        Use = "front",
        ET = "ET 20",
        Kg = "10,39"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 66",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x17",
        Use = "back",
        ET = "ET 26",
        Kg = "10,55"
    },
    //style 67
    new WheelSpecs
    {
        WheelStyleName = "style 67",
        Series = "3er E46",
        Model = "M3",
        Except = "",
        Size = "8x18 *",
        Use = "front",
        ET = "ET 47",
        Kg = "11,23"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 67",
        Series = "3er E46",
        Model = "M3",
        Except = "",
        Size = "9x18 *",
        Use = "back",
        ET = "ET 26",
        Kg = "11,23"
    },

    //style 68
    new WheelSpecs
    {
        WheelStyleName = "style 68",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "9,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 68",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 50",
        Kg = "9,92"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 68",
        Series = "3er E46",
        Model = "M3",
        Except = "",
        Size = "7,5x17 *",
        Use = "front",
        ET = "ET 47",
        Kg = "9,50"
    },
    new WheelSpecs
    {
        WheelStyleName = "style 68",
        Series = "3er E46",
        Model = "M3",
        Except = "",
        Size = "7,5x17 *",
        Use = "back",
        ET = "ET 25",
        Kg = "9,50"
    },
    //style 69
    new WheelSpecs
    {
        WheelStyleName = "style 69",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "11,33"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 69",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x18",
        Use = "back",
        ET = "ET 24",
        Kg = "11,23"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 69",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "11,50"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 69",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "9,5x18",
        Use = "back",
        ET = "ET 25",
        Kg = "11,50"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 69",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "8,5x18",
        Use = "",
        ET = "ET 48",
        Kg = "12,63"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 69",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "8,5x18 *",
        Use = "",
        ET = "ET 48",
        Kg = "11,23"
    },
     //style 70
     new WheelSpecs
    {
        WheelStyleName = "style 70",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 23",
        Kg = "14,78"
    },
     //style 71
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "9,92"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,36"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 50",
        Kg = "9,12"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x18",
        Use = "front",
        ET = "ET 47",
        Kg = "11,23"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8,5x18",
        Use = "back",
        ET = "ET 50",
        Kg = "11,30"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = "9,68"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "11,33"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x18",
        Use = "back",
        ET = "ET 24",
        Kg = "11,23"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "5er E60+",
        Model = "",
        Except = "4x4",
        Size = "8x18",
        Use = "",
        ET = "ET 18",
        Kg = "11,23"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "1.8/1.9, M",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "Z3 E36",
        Model = "Roadster, Coupe",
        Except = "1.8/1.9, M",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "9,92"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 71",
        Series = "Z4 E85+",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,37"
    },
     //style 72
     new WheelSpecs
    {
        WheelStyleName = "style 72",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x18",
        Use = "front",
        ET = "ET 47",
        Kg = "10,27"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 72",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8,5x18",
        Use = "back",
        ET = "ET 50",
        Kg = "11,78"
    },
     //style 73
     new WheelSpecs
    {
        WheelStyleName = "style 73",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7x17",
        Use = "",
        ET = "ET 47",
        Kg = "9,36"
    },
     //style 74
     new WheelSpecs
    {
        WheelStyleName = "style 74",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "8,5x18",
        Use = "",
        ET = "ET 48",
        Kg = "11,33"
    },
     //style 75
     new WheelSpecs
    {
        WheelStyleName = "style 75",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "9x19",
        Use = "front",
        ET = "ET 48",
        Kg = "12,63"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 75",
        Series = "X5 E53",
        Model = "",
        Except = "",
        Size = "10x19",
        Use = "back",
        ET = "ET 45",
        Kg = "13,27"
    },
     //style 76
     new WheelSpecs
    {
        WheelStyleName = "style 76",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 76",
        Series = "7er E38",
        Model = "",
        Except = "",
        Size = "9,5x18",
        Use = "back",
        ET = "ET 25",
        Kg = ""
    },
     //style 77
     new WheelSpecs
    {
        WheelStyleName = "style 77",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x18",
        Use = "front",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 77",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x18",
        Use = "back",
        ET = "",
        Kg = ""
    },
     //style 78
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "9,38"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,70"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "9,38"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M",
        Size = "7,5x17",
        Use = "",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "1.8/1.9, M",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 41",
        Kg = "10,16"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 78",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "1.8/1.9, M",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 41",
        Kg = "10,70"
    },
     //style 79
     new WheelSpecs
    {
        WheelStyleName = "style 79",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
     //style 80
     new WheelSpecs
    {
        WheelStyleName = "style 80",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 80",
        Series = "7er E38",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "ET 23",
        Kg = ""
    },
     //style 81
     new WheelSpecs
    {
        WheelStyleName = "style 81",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     //style 82
     new WheelSpecs
    {
        WheelStyleName = "style 82",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "7x16",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
     //style 83
     new WheelSpecs
    {
        WheelStyleName = "style 83",
        Series = "5er E39",
        Model = "520i-525i",
        Except = "",
        Size = "7x15",
        Use = "",
        ET = "",
        Kg = ""
    },
     //style 85
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "7,5x17",
        Use = "front",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "8,5x17",
        Use = "back",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "front",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8,5x17",
        Use = "back",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "5er E39",
        Model = "",
        Except = "Touring, M5",
        Size = "9x18",
        Use = "back",
        ET = "ET 24",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "1.8/1.9, M",
        Size = "7,5x17",
        Use = "front",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 85",
        Series = "Z3 E36",
        Model = "Roadster / Coupe",
        Except = "1.8/1.9, M",
        Size = "8,5x17",
        Use = "back",
        ET = "",
        Kg = ""
    },
     //style 86
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "3er E36",
        Model = "",
        Except = "Compact, M3",
        Size = "8,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "Z3 E36",
        Model = "Roadster 1.8/1.9",
        Except = "M",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "Z3 E36",
        Model = "Roadster/Coupe",
        Except = "1.8/1.9, M",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "Z3 E36",
        Model = "Roadster/Coupe",
        Except = "1.8/1.9, M",
        Size = "8,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8,5x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 86",
        Series = "5er E39",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "",
        Kg = ""
    },
     //style 87
     new WheelSpecs
    {
        WheelStyleName = "style 87",
        Series = "X5 E53",
        Model = "",
        Except = "erst ab 02/2001",
        Size = "9,5x20",
        Use = "front",
        ET = "ET 45",
        Kg = "12,46"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 87",
        Series = "X5 E53",
        Model = "",
        Except = "erst ab 02/2001",
        Size = "10,5x20",
        Use = "back",
        ET = "ET 30",
        Kg = "14,33"
    },
     //style 88
     new WheelSpecs
    {
        WheelStyleName = "style 88",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 88",
        Series = "3er E46",
        Model = "",
        Except = "330, M3",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 88",
        Series = "3er E46",
        Model = "Roadster, Coupe",
        Except = "M",
        Size = "7x16",
        Use = "",
        ET = "",
        Kg = ""
    },
     //style 89
     new WheelSpecs
    {
        WheelStyleName = "style 89",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 89",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 89",
        Series = "5er E39",
        Model = "",
        Except = "M5",
        Size = "8x17",
        Use = "",
        ET = "ET 20",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 89",
        Series = "5er E60+",
        Model = "",
        Except = "4x4",
        Size = "8x18",
        Use = "front",
        ET = "ET 20",
        Kg = "11,80"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 89",
        Series = "5er E60+",
        Model = "",
        Except = "4x4",
        Size = "9x18",
        Use = "back",
        ET = "ET 32",
        Kg = "11,80"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 89",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "9x19",
        Use = "front",
        ET = "ET 24",
        Kg = "11,80"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 89",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "10x19",
        Use = "back",
        ET = "ET 24",
        Kg = ""
    },
     //style 90
     new WheelSpecs
    {
        WheelStyleName = "style 90",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "8x17",
        Use = "",
        ET = "ET 24",
        Kg = ""
    },
     //style 91
     new WheelSpecs
    {
        WheelStyleName = "style 91",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "8x18",
        Use = "",
        ET = "ET 24",
        Kg = ""
    },
     //style 92
     new WheelSpecs
    {
        WheelStyleName = "style 92",
        Series = "6er E63+",
        Model = "",
        Except = "",
        Size = "8,5x19",
        Use = "front",
        ET = "ET 14",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 92",
        Series = "6er E63+",
        Model = "",
        Except = "",
        Size = "9x19",
        Use = "back",
        ET = "ET 18",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 92",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "9x19",
        Use = "front",
        ET = "ET 24",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 92",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "10x19",
        Use = "back",
        ET = "ET 24",
        Kg = ""
    },
     //style 93
     new WheelSpecs
    {
        WheelStyleName = "style 93",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "8x18",
        Use = "",
        ET = "ET 24",
        Kg = ""
    },
     //style 94
     new WheelSpecs
    {
        WheelStyleName = "style 94",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "8x18",
        Use = "",
        ET = "ET 24",
        Kg = ""
    },
     //style 95
     new WheelSpecs
    {
        WheelStyleName = "style 95",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "9x19",
        Use = "front",
        ET = "ET 24",
        Kg = ""
    },
     new WheelSpecs
    {
        WheelStyleName = "style 95",
        Series = "7er E65+",
        Model = "",
        Except = "",
        Size = "10x19",
        Use = "back",
        ET = "ET 24",
        Kg = ""
    },
     //style 96
     new WheelSpecs
    {
        WheelStyleName = "style 96",
        Series = "3er E36",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,49"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 96",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8x17",
        Use = "",
        ET = "ET 47",
        Kg = "10,49"
    },
     //style 97
     new WheelSpecs
    {
        WheelStyleName = "style 97",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7,5x17",
        Use = "front",
        ET = "ET 47",
        Kg = "10,49"
    },
     new WheelSpecs
    {
        WheelStyleName = "style 97",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "8,5x17",
        Use = "back",
        ET = "ET 42",
        Kg = "10,49"
    },
     //style 98
     new WheelSpecs
    {
        WheelStyleName = "style 98",
        Series = "3er E46",
        Model = "",
        Except = "M3",
        Size = "7x17",
        Use = "",
        ET = "ET 47",
        Kg = ""
    },
     //style 99
     new WheelSpecs
    {
        WheelStyleName = "style 99",
        Series = "X5 E53",
        Model = "4.6is",
        Except = "",
        Size = "8x18",
        Use = "",
        ET = "ET 40",
        Kg = "11,80"
    },
    //style 101
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "13,45"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "13,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x19",
                Use = "front",
                ET = "ET 20",
                Kg = "15,45"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9.5x19",
                Use = "back",
                ET = "ET 32",
                Kg = "16,15"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8.5x20",
                Use = "front",
                ET = "ET 14",
                Kg = "17,34"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9.5x20",
                Use = "back",
                ET = "ET 20",
                Kg = "17,85"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "front",
                ET = "ET 24",
                Kg = "17,15"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "13,45"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 101",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8.5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "13,80"
            },
            //style 102
            new WheelSpecs
            {
                WheelStyleName = "style 102",
                Series = "Z4 E85+",
                Model = "",
                Except = "Z4 3,0",
                Size = "7x16 *",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 103
            new WheelSpecs
            {
                WheelStyleName = "style 103",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 104
            new WheelSpecs
            {
                WheelStyleName = "style 104",
                Series = "Z4 E85+",
                Model = "",
                Except = "Z4 3,0",
                Size = "7x16 *",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 105
            new WheelSpecs
            {
                WheelStyleName = "style 105",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "",
                Kg = ""
            },
            //style 106
            new WheelSpecs
            {
                WheelStyleName = "style 106",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "",
                Kg = ""
            },
            //style 107
            new WheelSpecs
            {
                WheelStyleName = "style 107",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 107",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = ""
            },
            //style 108
            new WheelSpecs
            {
                WheelStyleName = "style 108",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 108",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = ""
            },
            //style 109
            new WheelSpecs
            {
                WheelStyleName = "style 109",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "",
                ET = "ET 39",
                Kg = "10,13"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 109",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 46",
                Kg = "9,14"
            },
            //style 110
            new WheelSpecs
            {
                WheelStyleName = "style 110",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "",
                ET = "ET 39",
                Kg = "9,35"
            },
            //style 111
            new WheelSpecs
            {
                WheelStyleName = "style 111",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 46",
                Kg = ""
            },
            //style 112
            new WheelSpecs
            {
                WheelStyleName = "style 112",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 46",
                Kg = ""
            },
            //style 113
            new WheelSpecs
            {
                WheelStyleName = "style 113",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 46",
                Kg = ""
            },
            //style 114
            new WheelSpecs
            {
                WheelStyleName = "style 114",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 46",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 114",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 51",
                Kg = ""
            },
            //style 115
            new WheelSpecs
            {
                WheelStyleName = "style 115",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "7x16",
                Use = "",
                ET = "",
                Kg = ""
            },
            //style 116
            new WheelSpecs
            {
                WheelStyleName = "style 116",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "7,5x17",
                Use = "",
                ET = "ET 20",
                Kg = "10,16"
            },
            //style 117
            new WheelSpecs
            {
                WheelStyleName = "style 117",
                Series = "6er E63+",
                Model = "",
                Except = "4x4",
                Size = "7,5x17",
                Use = "",
                ET = "ET 14",
                Kg = "13,00"
            },
            //style 118
            new WheelSpecs
            {
                WheelStyleName = "style 118",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 14",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 118",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 14",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 118",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "",
                ET = "ET 18",
                Kg = "11,74"
            },
            //style 119
            new WheelSpecs
            {
                WheelStyleName = "style 119",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = "10,49"
            },
            //style 120
            new WheelSpecs
            {
                WheelStyleName = "style 120",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 14",
                Kg = "10,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 120",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 18",
                Kg = "14,65"
            },
            //style 121
            new WheelSpecs
            {
                WheelStyleName = "style 121",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 14",
                Kg = "16,90"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 121",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 18",
                Kg = "16,90"
            },
            //style 122
            new WheelSpecs
            {
                WheelStyleName = "style 122",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x17",
                Use = "",
                ET = "ET 20",
                Kg = "11,50"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 122",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 43",
                Kg = "10,36"
            },
            //style 123
            new WheelSpecs
            {
                WheelStyleName = "style 123",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x18",
                Use = "",
                ET = "ET 20",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 123",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 43",
                Kg = "11,23"
            },
            //style 124
            new WheelSpecs
            {
                WheelStyleName = "style 124",
                Series = "5er E60+",
                Model = "",
                Except = "M5, 4x4",
                Size = "8x18",
                Use = "front",
                ET = "ET 20",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 124",
                Series = "5er E60+",
                Model = "",
                Except = "M5, 4x4",
                Size = "9x18",
                Use = "back",
                ET = "ET 32",
                Kg = "11,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 124",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 43",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 124",
                Series = "5er E60+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 55",
                Kg = "11,23"
            },
            //style 125
            new WheelSpecs
            {
                WheelStyleName = "style 125",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 125",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 125",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x19",
                Use = "front",
                ET = "ET 20",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 125",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 125",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 125",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = ""
            },
            //style 126
            new WheelSpecs
            {
                WheelStyleName = "style 126",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 24",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 126",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 24",
                Kg = ""
            },
            //style 127
            new WheelSpecs
            {
                WheelStyleName = "style 127",
                Series = "3er E46",
                Model = "M3 CSL",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 44",
                Kg = "12,62"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 127",
                Series = "3er E46",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 27",
                Kg = "13,79"
            },
            //style 128
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x19",
                Use = "front",
                ET = "ET 20",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "5er E60+",
                Model = "ab 03/04",
                Except = "4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 18",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "5er E60+",
                Model = "ab 03/04",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "9x21",
                Use = "front",
                ET = "ET 24",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "back",
                ET = "ET 24",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 46",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 51",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "18,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 42",
                Kg = "20,20"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "18,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 128",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "20,20"
            },
            //style 129
            new WheelSpecs
            {
                WheelStyleName = "style 129",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x18",
                Use = "",
                ET = "ET 20",
                Kg = "13,70"
            },
            //style 130
            new WheelSpecs
            {
                WheelStyleName = "style 130",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 48",
                Kg = "10,16"
            },
            //style 131
            new WheelSpecs
            {
                WheelStyleName = "style 131",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "",
                ET = "ET 48",
                Kg = "11,00"
            },
            //style 132
            new WheelSpecs
            {
                WheelStyleName = "style 132",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 132",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 45",
                Kg = ""
            },
            //style 133
            new WheelSpecs
            {
                WheelStyleName = "style 133",
                Series = "3er E36",
                Model = "",
                Except = "M3",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 133",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 133",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 134
            new WheelSpecs
            {
                WheelStyleName = "style 134",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "7x16",
                Use = "",
                ET = "ET 20",
                Kg = ""
            },
            //style 135
            new WheelSpecs
            {
                WheelStyleName = "style 135",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 135",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 135",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 135",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 135",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x18",
                Use = "",
                ET = "ET 20",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 135",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 43",
                Kg = "11,23"
            },
            //style 136
            new WheelSpecs
            {
                WheelStyleName = "style 136",
                Series = "3er E36",
                Model = "",
                Except = "M3",
                Size = "7x16",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 136",
                Series = "3er E46",
                Model = "",
                Except = "330, M3",
                Size = "7x16",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 136",
                Series = "Z3 E36",
                Model = "Roadster / Coupe",
                Except = "M",
                Size = "7x16",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 137
            new WheelSpecs
            {
                WheelStyleName = "style 137",
                Series = "3er E36",
                Model = "",
                Except = "M3",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 137",
                Series = "3er E36",
                Model = "",
                Except = "M3",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 137",
                Series = "3er E46",
                Model = "Roadster 1.8/1.9",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 138
            new WheelSpecs
            {
                WheelStyleName = "style 138",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "7,5x17",
                Use = "",
                ET = "ET 20",
                Kg = "9,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 138",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 43",
                Kg = "9,00"
            },
            //style 139
            new WheelSpecs
            {
                WheelStyleName = "style 139",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "6,5x16",
                Use = "",
                ET = "ET 42",
                Kg = ""
            },
            //style 140
            new WheelSpecs
            {
                WheelStyleName = "style 140",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 44",
                Kg = ""
            },
            //style 141
            new WheelSpecs
            {
                WheelStyleName = "style 141",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 142
            new WheelSpecs
            {
                WheelStyleName = "style 142",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 142",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "back",
                ET = "ET 47",
                Kg = ""
            },
            //style 143
            new WheelSpecs
            {
                WheelStyleName = "style 143",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 46",
                Kg = ""
            },
            //style 144
            new WheelSpecs
            {
                WheelStyleName = "style 144",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x17",
                Use = "",
                ET = "ET 20",
                Kg = "10,39"
            },
            //style 145
            new WheelSpecs
            {
                WheelStyleName = "style 145",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 145",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "",
                Kg = ""
            },
            //style 146
            new WheelSpecs
            {
                WheelStyleName = "style 146",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 46",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 146",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 51",
                Kg = "12,63"
            },
            //style 147
            new WheelSpecs
            {
                WheelStyleName = "style 147",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 46",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 147",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 51",
                Kg = "12,63"
            },
            //style 148
            new WheelSpecs
            {
                WheelStyleName = "style 148",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 46",
                Kg = ""
            },
            //style 149
            new WheelSpecs
            {
                WheelStyleName = "style 149",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "front",
                ET = "ET 24",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 149",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 24",
                Kg = ""
            },
            //style 150
            new WheelSpecs
            {
                WheelStyleName = "style 150",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 46",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 150",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 51",
                Kg = ""
            },
            //style 151
            new WheelSpecs
            {
                WheelStyleName = "style 151",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 44",
                Kg = ""
            },
            //style 152
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "3er E46",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "3er E46",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,93"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,93"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x18",
                Use = "",
                ET = "ET 20",
                Kg = "14,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 43",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 14",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 18",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "front",
                ET = "ET 24",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 24",
                Kg = "14,33"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 45",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 152",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,93"
            },
            //style 153
            new WheelSpecs
            {
                WheelStyleName = "style 153",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "",
                ET = "ET 48",
                Kg = "12,63"
            },
            //style 154
            new WheelSpecs
            {
                WheelStyleName = "style 154",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 34",
                Kg = "7,60"
            },
            //style 155
            new WheelSpecs
            {
                WheelStyleName = "style 155",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "",
                Kg = ""
            },
            //style 156
            new WheelSpecs
            {
                WheelStyleName = "style 155",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 34",
                Kg = ""
            },
            //style 157
            new WheelSpecs
            {
                WheelStyleName = "style 155",
                Series = "3er E90+",
                Model = "Coupe",
                Except = "335i",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "10,36"
            },
            //style 158
            new WheelSpecs
            {
                WheelStyleName = "style 155",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "9,38"
            },
            //style 159
            new WheelSpecs
            {
                WheelStyleName = "style 159",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "12,14"
            },
            //style 160
            new WheelSpecs
            {
                WheelStyleName = "style 160",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "12,00"
            },
            //style 161
            new WheelSpecs
            {
                WheelStyleName = "style 161",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "front",
                ET = "ET 34",
                Kg = "9,70"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 161",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x17",
                Use = "back",
                ET = "ET 37",
                Kg = "10,20"
            },
            //style 162
            new WheelSpecs
            {
                WheelStyleName = "style 162",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 162",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,93"
            },
            //style 163
            new WheelSpecs
            {
                WheelStyleName = "style 163",
                Series = "3er E46",
                Model = "M3 *",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 47",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 163",
                Series = "3er E46",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 27",
                Kg = "13,79"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 163",
                Series = "3er E46",
                Model = "M3 CSL",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 44",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 163",
                Series = "3er E46",
                Model = "M3 CSL",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 27",
                Kg = "11,53"
            },
            //style 164
            new WheelSpecs
            {
                WheelStyleName = "style 164",
                Series = "3er E46",
                Model = "M3, M3 CSL",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 41",
                Kg = "11,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 164",
                Series = "3er E46",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "back",
                ET = "ET 25",
                Kg = "11,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 164",
                Series = "Z4 E85+",
                Model = "Z4 M3.2",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 41",
                Kg = "11,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 164",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "back",
                ET = "ET 25",
                Kg = "11,00"
            },
            //style 165
            new WheelSpecs
            {
                WheelStyleName = "style 165",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 24",
                Kg = "9,68"
            },
            //style 166
            new WheelSpecs
            {
                WheelStyleName = "style 166",
                Series = "5er E60+",
                Model = "M5",
                Except = "4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 12",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 166",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 28",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 166",
                Series = "6er E63+",
                Model = "M6",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 12",
                Kg = "13,26"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 166",
                Series = "6er E63+",
                Model = "M6",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 17",
                Kg = "13,26"
            },
            //style 167
            new WheelSpecs
            {
                WheelStyleName = "style 167",
                Series = "5er E60+",
                Model = "M5",
                Except = "4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 12",
                Kg = "13,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 167",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 28",
                Kg = "13,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 167",
                Series = "6er E63+",
                Model = "M6",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 12",
                Kg = "13,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 167",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 17",
                Kg = "13,23"
            },
            //style 168
            new WheelSpecs
            {
                WheelStyleName = "style 168",
                Series = "X5 E53",
                Model = "4,8is",
                Except = "",
                Size = "9,5x20",
                Use = "front",
                ET = "ET 45",
                Kg = "12,46"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 168",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "10,5x20",
                Use = "back",
                ET = "ET 30",
                Kg = "14,33"
            },
            //style 169
            new WheelSpecs
            {
                WheelStyleName = "style 169",
                Series = "3er E46",
                Model = "",
                Except = "330, M3",
                Size = "7x16",
                Use = "",
                ET = "ET 47",
                Kg = ""
            },
            //style 170
            new WheelSpecs
            {
                WheelStyleName = "style 170",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8x17",
                Use = "",
                ET = "",
                Kg = ""
            },
            //style 171
            new WheelSpecs
            {
                WheelStyleName = "style 171",
                Series = "3er E46",
                Model = "",
                Except = "M3",
                Size = "8x17",
                Use = "",
                ET = "ET 47",
                Kg = "13,70"
            },
            //style 172
            new WheelSpecs
            {
                WheelStyleName = "style 172",
                Series = "5er E60+",
                Model = "",
                Except = "M5, 4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 18",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 172",
                Series = "5er E60+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = "13,26"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 172",
                Series = "5er E60+",
                Model = "touring",
                Except = "",
                Size = "8,5x19",
                Use = "",
                ET = "ET 18",
                Kg = "13,27"
            },
            //style 174
            new WheelSpecs
            {
                WheelStyleName = "style 174",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 24",
                Kg = "11,23"
            },
            //style 175
            new WheelSpecs
            {
                WheelStyleName = "style 175",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 24",
                Kg = "11,23"
            },
            //style 176
            new WheelSpecs
            {
                WheelStyleName = "style 176",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 24",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 176",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 24",
                Kg = "13,27"
            },
            //style 177
            new WheelSpecs
            {
                WheelStyleName = "style 177",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "9,5x20",
                Use = "front",
                ET = "ET 45",
                Kg = "12,46"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 177",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "10,5x20",
                Use = "back",
                ET = "ET 30",
                Kg = "14,31"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 177",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "",
                ET = "ET 46",
                Kg = "15,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 177",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "16,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 177",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 53",
                Kg = "16,60"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 177",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "18,90"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 177",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = "19,40"
            },
            //style 178
            new WheelSpecs
            {
                WheelStyleName = "style 178",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "front",
                ET = "ET 47",
                Kg = "10,13"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 178",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "back",
                ET = "ET 47",
                Kg = "10,13"
            },
            //style 179
            new WheelSpecs
            {
                WheelStyleName = "style 179",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 179",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "ET 49",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 179",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 179",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 179",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 18",
                Kg = "13,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 179",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = "13,27"
            },
            //style 180
            new WheelSpecs
            {
                WheelStyleName = "style 180",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 180",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "ET 49",
                Kg = ""
            },
            //style 181
            new WheelSpecs
            {
                WheelStyleName = "style 181",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 181",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "ET 49",
                Kg = ""
            },
            //style 182
            new WheelSpecs
            {
                WheelStyleName = "style 182",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 47",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 182",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "ET 49",
                Kg = ""
            },
            //style 183
            new WheelSpecs
            {
                WheelStyleName = "style 183",
                Series = "X5 E53",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "",
                ET = "ET 48",
                Kg = "11,93"
            },
            //style 184
            new WheelSpecs
            {
                WheelStyleName = "style 184",
                Series = "5er E60+",
                Model = "",
                Except = "M5, 4x4",
                Size = "8x18",
                Use = "",
                ET = "ET 20",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 184",
                Series = "5er E60+",
                Model = "M5",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 14",
                Kg = "13,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 184",
                Series = "6er E63+",
                Model = "",
                Except = "M6",
                Size = "8x18",
                Use = "",
                ET = "ET 14",
                Kg = "13,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 184",
                Series = "6er E63+",
                Model = "",
                Except = "M6",
                Size = "8x18",
                Use = "",
                ET = "ET 14",
                Kg = "13,80"
            },
            //style 185
            new WheelSpecs
            {
                WheelStyleName = "style 185",
                Series = "3er E90+",
                Model = "Coupe",
                Except = "Nicht 335i",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "10,36"
            },
            //style 187
            new WheelSpecs
            {
                WheelStyleName = "style 187",
                Series = "3er E90+",
                Model = "Coupe",
                Except = "335i",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "9,38"
            },
            //style 188
            new WheelSpecs
            {
                WheelStyleName = "style 188",
                Series = "3er E90+",
                Model = "Coupe",
                Except = "",
                Size = "8x17",
                Use = "front",
                ET = "ET 34",
                Kg = "10,36"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 188",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x17",
                Use = "back",
                ET = "ET 37",
                Kg = "10,70"
            },
            //style 189
            new WheelSpecs
            {
                WheelStyleName = "style 189",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 189",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,93"
            },
            //style 190
            new WheelSpecs
            {
                WheelStyleName = "style 190",
                Series = "3er E90+",
                Model = "Coupe",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 190",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 190",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 18",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 190",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = ""
            },
            //style 191
            new WheelSpecs
            {
                WheelStyleName = "style 191",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "",
                ET = "ET 46",
                Kg = "13,26"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 191",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "",
                ET = "ET 51",
                Kg = "12,62"
            },
            //style 192
            new WheelSpecs
            {
                WheelStyleName = "style 192",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 44",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 192",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "",
                ET = "ET 51",
                Kg = "11,93"
            },
            //style 193
            new WheelSpecs
            {
                WheelStyleName = "style 193",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 193",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,93"
            },
            //style 194
            new WheelSpecs
            {
                WheelStyleName = "style 194",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "front",
                ET = "ET 34",
                Kg = "10,36"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 194",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x17",
                Use = "back",
                ET = "ET 37",
                Kg = "10,70"
            },
            //style 195
            new WheelSpecs
            {
                WheelStyleName = "style 195",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 195",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,23"
            },
            //style 196
            new WheelSpecs
            {
                WheelStyleName = "style 196",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 196",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,93"
            },
            //style 197
            new WheelSpecs
            {
                WheelStyleName = "style 197",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 197",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,93"
            },
            //style 198
            new WheelSpecs
            {
                WheelStyleName = "style 198",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 198",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "13,23"
            },
            //style 199
            new WheelSpecs
            {
                WheelStyleName = "style 199",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,62"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 199",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "13,23"
            },
            //style 200
            new WheelSpecs
            {
                WheelStyleName = "style 200",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 46",
                Kg = "10,36"
            },
            //style 201
            new WheelSpecs
            {
                WheelStyleName = "style 201",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 46",
                Kg = "10,36"
            },
            //style 202
            new WheelSpecs
            {
                WheelStyleName = "style 202",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 46",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 202",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,93"
            },
            //style 203
            new WheelSpecs
            {
                WheelStyleName = "style 203",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 203",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,93"
            },
            //style 204
            new WheelSpecs
            {
                WheelStyleName = "style 204",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "back",
                ET = "ET 46",
                Kg = "10,36"
            },
            //style 205
            new WheelSpecs
            {
                WheelStyleName = "style 205",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 46",
                Kg = "11,23"
            },
            //style 206
            new WheelSpecs
            {
                WheelStyleName = "style 206",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 46",
                Kg = "11,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 206",
                Series = "X3 E83",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 51",
                Kg = "11,30"
            },
            //style 207
            new WheelSpecs
            {
                WheelStyleName = "style 207",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "front",
                ET = "ET 47",
                Kg = "10,13"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 207",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "back",
                ET = "ET 47",
                Kg = "10,16"
            },
            //style 208
            new WheelSpecs
            {
                WheelStyleName = "style 208",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 40",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 208",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "ET 49",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 208",
                Series = "1er E87+",
                Model = "LCI",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 208",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "12,50"
            },
            //style 209
            new WheelSpecs
            {
                WheelStyleName = "style 209",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "",
                ET = "ET 46",
                Kg = "12,60"
            },
            //style 210
            new WheelSpecs
            {
                WheelStyleName = "style 210",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "",
                ET = "ET 46",
                Kg = "14,00"
            },
            //style 211
            new WheelSpecs
            {
                WheelStyleName = "style 211",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "",
                ET = "ET 48",
                Kg = "15,80"
            },
            //style 212
            new WheelSpecs
            {
                WheelStyleName = "style 212",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "",
                ET = "ET 48",
                Kg = "15,50"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 212",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "15,60"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 212",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 18",
                Kg = "14,60"
            },
            //style 213
            new WheelSpecs
            {
                WheelStyleName = "style 213",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "16,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 213",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 53",
                Kg = "16,70"
            },
            //style 214
            new WheelSpecs
            {
                WheelStyleName = "style 214",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "17,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 214",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = "17,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 214",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "18,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 214",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = "19,00"
            },
            //style 215
             new WheelSpecs
            {
                WheelStyleName = "style 215",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "17,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 215",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "17,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 215",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "19,60"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 215",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "17,30"
            },
            //style 216
            new WheelSpecs
            {
                WheelStyleName = "style 216",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 216",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,93"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 216",
                Series = "1er E87+",
                Model = "LCI",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 216",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,93"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 216",
                Series = "3er E90+",
                Model = "320si",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 216",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 37",
                Kg = "11,30"
            },
            //style 217
            new WheelSpecs
            {
                WheelStyleName = "style 217",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 217",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "ET 49",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 217",
                Series = "1er E87+",
                Model = "LCI",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 217",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,00"
            },
            //style 218
            new WheelSpecs
            {
                WheelStyleName = "style 218",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "",
                ET = "ET 14",
                Kg = "14,40"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 218",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "",
                ET = "ET 18",
                Kg = "14,60"
            },
            //style 219
            new WheelSpecs
            {
                WheelStyleName = "style 219",
                Series = "3er E90+",
                Model = "M3",
                Except = "",
                Size = "8,5x18",
                Use = "front",
                ET = "ET 29",
                Kg = "11,70"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 219",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9,5x18",
                Use = "back",
                ET = "ET 23",
                Kg = "12,60"
            },
            //style 220
            new WheelSpecs
            {
                WheelStyleName = "style 220",
                Series = "3er E90+",
                Model = "M3",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 29",
                Kg = "13,26"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 220",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 23",
                Kg = "13,26"
            },
            //style 222
            new WheelSpecs
            {
                WheelStyleName = "style 222",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 44",
                Kg = ""
            },
            //style 223
            new WheelSpecs
            {
                WheelStyleName = "style 223",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 37",
                Kg = "16,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 223",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 20",
                Kg = "17,00"
            },
            //style 224
            new WheelSpecs
            {
                WheelStyleName = "style 224",
                Series = "Z4 E85+",
                Model = "Z4 M3.2",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 42",
                Kg = "11,20"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 224",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 30",
                Kg = "11,70"
            },
            //style 225
            new WheelSpecs
            {
                WheelStyleName = "style 225",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 225",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "12,63"
            },
            //style 227
            new WheelSpecs
            {
                WheelStyleName = "style 227",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "18,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 227",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 35",
                Kg = "19,00"
            },
            //style 228
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,75"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "13,85"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 18",
                Kg = "14,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = "14,60"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "13,40"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "14,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "13,85"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 228",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "13,90"
            },
            //style 229
            new WheelSpecs
            {
                WheelStyleName = "style 229",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "back",
                ET = "ET 44",
                Kg = "10,24"
            },
            //style 230
            new WheelSpecs
            {
                WheelStyleName = "style 230",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,63"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 230",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "12,63"
            },
            //style 231
            new WheelSpecs
            {
                WheelStyleName = "style 231",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 24",
                Kg = "11,11"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 231",
                Series = "7er E65+",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 24",
                Kg = "11,11"
            },
            //style 232
            new WheelSpecs
            {
                WheelStyleName = "style 232",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "",
                ET = "ET 48",
                Kg = "16,20"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 232",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "16,20"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 232",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 18",
                Kg = "16,40"
            },
            //style 233
            new WheelSpecs
            {
                WheelStyleName = "style 233",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "",
                Kg = ""
            },
            //style 234
            new WheelSpecs
            {
                WheelStyleName = "style 234",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "11,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 234",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "11,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 234",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "11,10"
            },
            //style 236
            new WheelSpecs
            {
                WheelStyleName = "style 236",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 30",
                Kg = "9,93"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 236",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 30",
                Kg = "9,93"
            },
            //style 237
            new WheelSpecs
            {
                WheelStyleName = "style 237",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "12,48"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 237",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "12,48"
            },
            //style 238
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8x18 *",
                Use = "",
                ET = "ET 30",
                Kg = "12,40"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8x19 *",
                Use = "",
                ET = "ET 25",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "14,60"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "14,90"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = "15,80"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "17,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x21",
                Use = "front",
                ET = "ET 25",
                Kg = "17,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "back",
                ET = "ET 41",
                Kg = "18,10"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8x18 *",
                Use = "",
                ET = "ET 30",
                Kg = "12,40"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x19 *",
                Use = "",
                ET = "ET 25",
                Kg = "14,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "14,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "14,90"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = "17,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7	10x20",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "18,20"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7	10x20",
                Model = "",
                Except = "",
                Size = "8,5x21",
                Use = "front",
                ET = "ET 25",
                Kg = "19,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 238",
                Series = "7	10x20",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "back",
                ET = "ET 41",
                Kg = "19,50"
            },
            //style 239
            new WheelSpecs
            {
                WheelStyleName = "style 239",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "18,50"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 239",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "19,00"
            },
            //style 241
            new WheelSpecs
            {
                WheelStyleName = "style 241",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "19,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 241",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = ""
            },
            //style 242
            new WheelSpecs
            {
                WheelStyleName = "style 242",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "7x16",
                Use = "",
                ET = "ET 20",
                Kg = "9,57"
            },
            //style 243
            new WheelSpecs
            {
                WheelStyleName = "style 243",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "7,5x17",
                Use = "",
                ET = "ET 20",
                Kg = "9,30"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 243",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 43",
                Kg = "9,50"
            },
            //style 244
            new WheelSpecs
            {
                WheelStyleName = "style 244",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "7,5x17",
                Use = "",
                ET = "ET 20",
                Kg = "9,50"
            },

            //Style 245
            new WheelSpecs
            {
                WheelStyleName = "style 245",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x17",
                Use = "",
                ET = "ET 20",
                Kg = "11,98"
            },
            //style 246
            new WheelSpecs
            {
                WheelStyleName = "style 246",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x18",
                Use = "",
                ET = "ET 20",
                Kg = "11,23"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 246",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 43",
                Kg = "11,23"
            },
            //style 247
            new WheelSpecs
            {
                WheelStyleName = "style 247",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x18",
                Use = "front",
                ET = "ET 20",
                Kg = "10,27"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 247",
                Series = "5er E60+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 32",
                Kg = "10,27"
            },
            //style 248
            new WheelSpecs
            {
                WheelStyleName = "style 248",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 14",
                Kg = "13,09"
            },
            //style 249
            new WheelSpecs
            {
                WheelStyleName = "style 249",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 14",
                Kg = "12,52"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 249",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 14",
                Kg = "12,65"
            },
            //style 250
            new WheelSpecs
            {
                WheelStyleName = "style 250",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8x18 *",
                Use = "",
                ET = "ET 30",
                Kg = "12,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 250",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "12,00"
            },
            //style 251
            new WheelSpecs
            {
                WheelStyleName = "style 251",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8x19 *",
                Use = "",
                ET = "",
                Kg = ""
            },
            new WheelSpecs
            {
                WheelStyleName = "style 251",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "16,90"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 251",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "17,00"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 251",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x19 *",
                Use = "back",
                ET = "ET 25",
                Kg = "17,75"
            },
            new WheelSpecs
            {
                WheelStyleName = "style 251",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "17,75"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 251",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "16,50"
            },
             //style 252
             new WheelSpecs
            {
                WheelStyleName = "style 252",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "12,00"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 252",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "12,30"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 252",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "14,40"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 252",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "16,50"
            },
             //style 253
             new WheelSpecs
            {
                WheelStyleName = "style 253",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = "16,00"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 253",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "16,60"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 253",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = "17,00"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 253",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "18,20"
            },
             //style 254
             new WheelSpecs
            {
                WheelStyleName = "style 254",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8x18 *",
                Use = "",
                ET = "ET 30",
                Kg = "14,20"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 254",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "13,70"
            },
             //style 255
             new WheelSpecs
            {
                WheelStyleName = "style 255",
                Series = "1er E87+",
                Model = "",
                Except = ">= 125i, 123d",
                Size = "7x16",
                Use = "",
                ET = "ET 44",
                Kg = "9,33"
            },
             //style 256
             new WheelSpecs
            {
                WheelStyleName = "style 256",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "",
                ET = "ET 47",
                Kg = "10,13"
            },
             //style 257
             new WheelSpecs
            {
                WheelStyleName = "style 257",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "15,20"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 257",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 18",
                Kg = "15,90"
            },
             //style 258
             new WheelSpecs
            {
                WheelStyleName = "style 258",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "15,40"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 258",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 21",
                Kg = "16,00"
            },
             //style 259
             new WheelSpecs
            {
                WheelStyleName = "style 259",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "18,40"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 259",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = "18,70"
            },
             //style 260
             new WheelSpecs
            {
                WheelStyleName = "style 260",
                Series = "3er E90+",
                Model = "M3",
                Except = "",
                Size = "8,5x18",
                Use = "front",
                ET = "ET 29",
                Kg = "11,33"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 260",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9,5x18",
                Use = "back",
                ET = "ET 23",
                Kg = "10,54"
            },
             //style 261
             new WheelSpecs
            {
                WheelStyleName = "style 261",
                Series = "1er E87+",
                Model = "Coupe",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,80"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 261",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,23"
            },
             //style 262
             new WheelSpecs
            {
                WheelStyleName = "style 262",
                Series = "1er E87+",
                Model = "Coupe",
                Except = "",
                Size = "7x17",
                Use = "front",
                ET = "ET 47",
                Kg = "10,13"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 262",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "back",
                ET = "ET 47",
                Kg = "9,45"
            },
             //style 263
             new WheelSpecs
            {
                WheelStyleName = "style 263",
                Series = "1er E87+",
                Model = "Coupe",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,00"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 263",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,23"
            },
             //style 264
             new WheelSpecs
            {
                WheelStyleName = "style 264",
                Series = "1er E87+",
                Model = "Coupe",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,00"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 264",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,92"
            },
             //style 265
             new WheelSpecs
            {
                WheelStyleName = "style 265",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "16,30"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 265",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 53",
                Kg = "16,40"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 265",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "16,30"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 265",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 21",
                Kg = ""
            },
             //style 266
             new WheelSpecs
            {
                WheelStyleName = "style 266",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 14",
                Kg = "12,98"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 266",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 14",
                Kg = "13,45"
            },
             //style 268
             new WheelSpecs
            {
                WheelStyleName = "style 268",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 31",
                Kg = "9,30"
            },
             //style 269
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,98"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,93"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "3er E46",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "11,90"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "3er E46",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,60"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "3er E90+",
                Model = "",
                Except = "X-Drive",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,95"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "13,85"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "13,85"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 47",
                Kg = "11,90"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "Z4 E85+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 50",
                Kg = "11,60"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 18",
                Kg = "13,20"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 269",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 32",
                Kg = "13,90"
            },

             //style 270
             new WheelSpecs
            {
                WheelStyleName = "style 270",
                Series = "1er E87+",
                Model = "M Coupe",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 20",
                Kg = "13,90"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 270",
                Series = "3er E90+",
                Model = "M3",
                Except = "",
                Size = "8x18 *",
                Use = "",
                ET = "ET 20",
                Kg = ""
            },

             //style 271
             new WheelSpecs
            {
                WheelStyleName = "style 271",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = ""
            },
             //style 272
             new WheelSpecs
            {
                WheelStyleName = "style 272",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "15,70"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 272",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "15,70"
            },
             //style 275
             new WheelSpecs
            {
                WheelStyleName = "style 275",
                Series = "X5 E70",
                Model = "X5 M",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "19,80"
            },
             new WheelSpecs
            {
                WheelStyleName = "style 275",
                Series = "X5 E70",
                Model = "X5 M",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "21,70"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 275",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "19,80"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 275",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "21,70"
            },

              //style 276
              new WheelSpecs
            {
                WheelStyleName = "style 276",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x17 *",
                Use = "",
                ET = "ET 29",
                Kg = "12,00"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 276",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 29",
                Kg = "11,93"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 276",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 40",
                Kg = "11,92"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 276",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 29",
                Kg = "12,60"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 276",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 40",
                Kg = "13,23"
            },
              //style 277
              new WheelSpecs
            {
                WheelStyleName = "style 277",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x17",
                Use = "",
                ET = "ET 20",
                Kg = "11,70"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 277",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 43",
                Kg = "10,36"
            },
              //style 278
              new WheelSpecs
            {
                WheelStyleName = "style 278",
                Series = "5er E60+",
                Model = "",
                Except = "4x4",
                Size = "8x17",
                Use = "",
                ET = "ET 20",
                Kg = "10,36"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 278",
                Series = "5er E60+",
                Model = "4x4",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 43",
                Kg = "10,36"
            },
              //style 279
              new WheelSpecs
            {
                WheelStyleName = "style 279",
                Series = "X3 E83",
                Model = "Edition",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 46",
                Kg = "10,36"
            },
              //style 280
              new WheelSpecs
            {
                WheelStyleName = "style 280",
                Series = "X3 E83",
                Model = "Edition",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "",
                Kg = ""
            },
              //style 281
              new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18 *",
                Use = "",
                ET = "ET 30",
                Kg = "11,90"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "11,90"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,20"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "13,00"
            },
              new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "13,90"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "14,60"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "14,70"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18 *",
                Use = "",
                ET = "ET 30",
                Kg = "11,90"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "11,90"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,20"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "13,00"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "13,90"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "14,60"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 281",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "14,70"
            },
               //style 282
               new WheelSpecs
            {
                WheelStyleName = "style 282",
                Series = "3er E90+",
                Model = "",
                Except = "ab 330i, 325d",
                Size = "7x16",
                Use = "",
                ET = "ET 31",
                Kg = "10,40"
            },
               //style 283
               new WheelSpecs
            {
                WheelStyleName = "style 283",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 34",
                Kg = "8,15"
            },
               //style 284
               new WheelSpecs
            {
                WheelStyleName = "style 284",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "10,36"
            },
               //style 285
               new WheelSpecs
            {
                WheelStyleName = "style 285",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "10,36"
            },
               //style 286
               new WheelSpecs
            {
                WheelStyleName = "style 286",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "front",
                ET = "ET 34",
                Kg = "12,00"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 286",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x17",
                Use = "back",
                ET = "ET 39",
                Kg = "10,70"
            },
               //style 287
               new WheelSpecs
            {
                WheelStyleName = "style 287",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,23"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 287",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 39",
                Kg = "11,93"
            },
               //style 288
               new WheelSpecs
            {
                WheelStyleName = "style 288",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 14",
                Kg = "13,27"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 288",
                Series = "6er E63+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 14",
                Kg = "12,63"
            },
               //style 290
               new WheelSpecs
            {
                WheelStyleName = "style 290",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 29",
                Kg = "12,14"
            },
               //style 292
               new WheelSpecs
            {
                WheelStyleName = "style 292",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "front",
                ET = "ET 29",
                Kg = "12,18"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 292",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8,5x17",
                Use = "back",
                ET = "ET 40",
                Kg = "12,02"
            },
               //style 293
               new WheelSpecs
            {
                WheelStyleName = "style 293",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 29",
                Kg = "11,23"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 293",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 40",
                Kg = "11,93"
            },
               //style 294
               new WheelSpecs
            {
                WheelStyleName = "style 294",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 29",
                Kg = "11,23"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 294",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 40",
                Kg = "11,93"
            },
               //style 295
               new WheelSpecs
            {
                WheelStyleName = "style 295",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 29",
                Kg = "12,45"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 295",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 40",
                Kg = "12,60"
            },
               //style 296
               new WheelSpecs
            {
                WheelStyleName = "style 296",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 29",
                Kg = "12,60"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 296",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 40",
                Kg = "13,23"
            },
               //style 297
               new WheelSpecs
            {
                WheelStyleName = "style 297",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "19,40"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 297",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = "20,60"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 297",
                Series = "X6 E71",
                Model = "Active Hybrid",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "19,40"
            },
               new WheelSpecs
            {
                WheelStyleName = "style 297",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = "20,60"
            },
               //style 298
                new WheelSpecs
            {
                WheelStyleName = "style 298",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19 *",
                Use = "",
                ET = "ET 37",
                Kg = "15,50"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 298",
                Series = "X5 E70",
                Model = "X5 M",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 37",
                Kg = "15,50"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 298",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 18",
                Kg = "15,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 298",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "9x19 *",
                Use = "",
                ET = "",
                Kg = "15,50"
            },
                //style 299
                new WheelSpecs
            {
                WheelStyleName = "style 299",
                Series = "X5 E70",
                Model = "X5 M",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "18,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 299",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 35",
                Kg = "19,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 299",
                Series = "X6 E71",
                Model = "X6 M",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "18,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 299",
                Series = "X6 E71",
                Model = "X6 M",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 35",
                Kg = "19,30"
            },
                //style 300
                new WheelSpecs
            {
                WheelStyleName = "style 300",
                Series = "X5 E70",
                Model = "X5 M",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "17,85"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 300",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 35",
                Kg = "18,70"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 300",
                Series = "X6 E71",
                Model = "X6 M",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "17,85"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 300",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 35",
                Kg = "18,70"
            },
                //style 301
                new WheelSpecs
            {
                WheelStyleName = "style 301",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = "16,10"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 301",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "17,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 301",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = "16,10"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 301",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "17,00"
            },
                //style 302
                new WheelSpecs
            {
                WheelStyleName = "style 302",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "13,90"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 302",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "14,20"
            },
                //style 303
               new WheelSpecs
            {
                WheelStyleName = "style 303",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = "15,10"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 303",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "16,20"
            },
                //style 304
                new WheelSpecs
            {
                WheelStyleName = "style 304",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 304",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 305
                new WheelSpecs
            {
                WheelStyleName = "style 305",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 306
                new WheelSpecs
            {
                WheelStyleName = "style 306",
                Series = "3er E90+",
                Model = "320d eff. Dynamic",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 31",
                Kg = "9,19"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 306",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 31",
                Kg = "9,19"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 306",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 307
                new WheelSpecs
            {
                WheelStyleName = "style 307",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 308
                new WheelSpecs
            {
                WheelStyleName = "style 308",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 309
                new WheelSpecs
            {
                WheelStyleName = "style 309",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 309",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 309",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "",
                Kg = ""
            },
                //style 310
                new WheelSpecs
            {
                WheelStyleName = "style 310",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 310",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "",
                Kg = ""
            },
                //style 311
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "13,15"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "13,96"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "16,70"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "16,45"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x21",
                Use = "front",
                ET = "ET 25",
                Kg = "18,90"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "back",
                ET = "ET 41",
                Kg = "19,50"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "16,70"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "16,45"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x21",
                Use = "front",
                ET = "ET 25",
                Kg = "19,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "back",
                ET = "ET 41",
                Kg = "19,50"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 30",
                Kg = "15,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 41",
                Kg = "15,80"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 311",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = "15,80"
            },
                //style 312
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "15,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "15,40"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x21",
                Use = "front",
                ET = "ET 25",
                Kg = "16,40"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "back",
                ET = "ET 41",
                Kg = "16,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "15,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "15,40"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "8,5x21",
                Use = "front",
                ET = "ET 25",
                Kg = "19,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 312",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "10x21",
                Use = "back",
                ET = "ET 41",
                Kg = "19,50"
            },
                //style 313
                new WheelSpecs
            {
                WheelStyleName = "style 313",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "ET 49",
                Kg = "11,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 313",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 52",
                Kg = "11,93"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 313",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 37",
                Kg = "12,63"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 313",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 39",
                Kg = "13,27"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 313",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 29",
                Kg = "12,63"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 313",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 40",
                Kg = "13,27"
            },
                //style 315
                new WheelSpecs
            {
                WheelStyleName = "style 315",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 25",
                Kg = "14,80"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 315",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "ET 39",
                Kg = "15,90"
            },
                //style 316
                new WheelSpecs
            {
                WheelStyleName = "style 316",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 25",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 316",
                Series = "5er GT F07",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 41",
                Kg = ""
            },
                //style 317
                new WheelSpecs
            {
                WheelStyleName = "style 317",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 34",
                Kg = "11,90"
            },
                //style 318
                new WheelSpecs
            {
                WheelStyleName = "style 318",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 34",
                Kg = "12,55"
            },

                //Style 319
                new WheelSpecs
            {
                WheelStyleName = "style 319",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 34",
                Kg = "11,00"
            },
                //style 320
                new WheelSpecs
            {
                WheelStyleName = "style 320",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "13,34"
            },
                //style 321
                new WheelSpecs
            {
                WheelStyleName = "style 321",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "13,70"
            },
                //style 322
                new WheelSpecs
            {
                WheelStyleName = "style 322",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "13,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 322",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 41",
                Kg = "13,35"
            },
                //style 323
                new WheelSpecs
            {
                WheelStyleName = "style 323",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "13,48"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 323",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 41",
                Kg = "13,03"
            },
                //style 324
                new WheelSpecs
            {
                WheelStyleName = "style 324",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 30",
                Kg = "12,52"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 324",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 41",
                Kg = "12,81"
            },
                //style 325
                new WheelSpecs
            {
                WheelStyleName = "style 325",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 29",
                Kg = "11,23"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 325",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ER 40",
                Kg = "11,93"
            },
                //style 326
                new WheelSpecs
            {
                WheelStyleName = "style 326",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 29",
                Kg = "13,95"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 326",
                Series = "Z4 E89",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 40",
                Kg = "13,80"
            },
                //style 327
                new WheelSpecs
            {
                WheelStyleName = "style 327",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 30",
                Kg = "11,88"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 327",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 30",
                Kg = "11,88"
            },
                //style 328
                new WheelSpecs
            {
                WheelStyleName = "style 328",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "12,77"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 328",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "12,77"
            },
                //style 329
                new WheelSpecs
            {
                WheelStyleName = "style 329",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "12,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 329",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "12,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 329",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 329",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 30",
                Kg = "12,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 329",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "12,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 329",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,60"
            },
                //style 330
                new WheelSpecs
            {
                WheelStyleName = "style 330",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "12,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 330",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,90"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 330",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "12,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 330",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,90"
            },
                //style 331
                new WheelSpecs
            {
                WheelStyleName = "style 331",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "16,10"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 331",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "16,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 331",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "16,10"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 331",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "16,30"
            },
                //style 332
                new WheelSpecs
            {
                WheelStyleName = "style 332",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,41"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 332",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,41"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 332",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,41"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 332",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,41"
            },
                //style 333
                new WheelSpecs
            {
                WheelStyleName = "style 333",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "20,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 333",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 35",
                Kg = "20,20"
            },
                //style 334
                new WheelSpecs
            {
                WheelStyleName = "style 334",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "",
                ET = "ET 48",
                Kg = "15,80"
            },
                //style 335
                new WheelSpecs
            {
                WheelStyleName = "style 335",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 48",
                Kg = "16,70"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 335",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 53",
                Kg = "17,70"
            },
                //style 336
                new WheelSpecs
            {
                WheelStyleName = "style 336",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "20,50"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 336",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 336",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "20,50"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 336",
                Series = "X6 E71",
                Model = "",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = ""
            },
                //style 337
                new WheelSpecs
            {
                WheelStyleName = "style 337",
                Series = "X5 E70",
                Model = "Edition",
                Except = "",
                Size = "10x20",
                Use = "front",
                ET = "ET 40",
                Kg = "20,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 337",
                Series = "X5 E70",
                Model = "Edition",
                Except = "",
                Size = "11x20",
                Use = "back",
                ET = "ET 37",
                Kg = "21,00"
            },
                //style 338
                new WheelSpecs
            {
                WheelStyleName = "style 338",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "12,15"
            },
                //style 339
                new WheelSpecs
            {
                WheelStyleName = "style 339",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "11,40"
            },
                //style 340
                new WheelSpecs
            {
                WheelStyleName = "style 340",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "front",
                ET = "ET 34",
                Kg = "11,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 340",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8,5x17",
                Use = "back",
                ET = "ET 37",
                Kg = "11,70"
            },
                //style 342
                new WheelSpecs
            {
                WheelStyleName = "style 342",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 34",
                Kg = "11,70"
            },
                //style 343
                new WheelSpecs
            {
                WheelStyleName = "style 343",
                Series = "5er F10+",
                Model = "M5",
                Except = "",
                Size = "9x20",
                Use = "front",
                ET = "ET 34",
                Kg = "11,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 343",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "10x20",
                Use = "back",
                ET = "ET 34",
                Kg = "11,70"
            },
                //style 345
                new WheelSpecs
            {
                WheelStyleName = "style 345",
                Series = "5er F10+",
                Model = "M5",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 32",
                Kg = "12,02"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 345",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 34",
                Kg = "12,32"
            },
                //style 349
                new WheelSpecs
            {
                WheelStyleName = "style 349",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,75"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 349",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,95"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 349",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,75"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 349",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,95"
            },
                //style 350
                new WheelSpecs
            {
                WheelStyleName = "style 350",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "11,40"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 350",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "11,90"
            },
                //style 351
                new WheelSpecs
            {
                WheelStyleName = "style 351",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,53"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 351",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,51"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 351",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,53"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 351",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,51"
            },
                //style 354
                new WheelSpecs
            {
                WheelStyleName = "style 354",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 34",
                Kg = "10,66"
            },
                //style 355
                new WheelSpecs
            {
                WheelStyleName = "style 355",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "12,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 355",
                Series = "X1 E84",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 41",
                Kg = "12,60"
            },
                //style 356
                new WheelSpecs
            {
                WheelStyleName = "style 356",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "15,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 356",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "15,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 356",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "15,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 356",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "15,60"
            },
                //style 357
                new WheelSpecs
            {
                WheelStyleName = "style 357",
                Series = "7er F01+",
                Model = "active Hybrid",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 357",
                Series = "7er F01+",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "",
                Kg = ""
            },
                //style 358
                new WheelSpecs
            {
                WheelStyleName = "style 359",
                Series = "1er E87+",
                Model = "M Coupe",
                Except = "",
                Size = "9x19 *",
                Use = "front",
                ET = "ET 31",
                Kg = "11,90"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 359",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "10x19 *",
                Use = "back",
                ET = "ET 25",
                Kg = "11,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 359",
                Series = "3er E90+",
                Model = "M3",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 31",
                Kg = "11,90"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 359",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "10x19",
                Use = "back",
                ET = "ET 25",
                Kg = "11,20"
            },
                //style 360
                new WheelSpecs
            {
                WheelStyleName = "style 360",
                Series = "1er E87+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 44",
                Kg = "7,50"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 360",
                Series = "3er E90+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 31",
                Kg = "8,00"
            },
                //style 361
                new WheelSpecs
            {
                WheelStyleName = "style 361",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7,5x19",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 361",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "back",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 361",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8x20",
                Use = "front",
                ET = "ET 36",
                Kg = "13,15"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 361",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "back",
                ET = "ET 47",
                Kg = "12,97"
            },
                //style 363
                new WheelSpecs
            {
                WheelStyleName = "style 363",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "",
                ET = "ET 30",
                Kg = "12,06"
            },
                //style 365
                new WheelSpecs
            {
                WheelStyleName = "style 365",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "12,13"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 365",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,46"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 365",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 30",
                Kg = "12,13"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 365",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x18",
                Use = "back",
                ET = "ET 44",
                Kg = "12,46"
            },
                //style 366
                new WheelSpecs
            {
                WheelStyleName = "style 366",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 366",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,30"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 366",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 366",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,30"
            },
                //style 367
                new WheelSpecs
            {
                WheelStyleName = "style 367",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 367",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,90"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 367",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "ET 33",
                Kg = "14,60"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 367",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 44",
                Kg = "14,90"
            },
                //style 368
                new WheelSpecs
            {
                WheelStyleName = "style 368",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 369
                new WheelSpecs
            {
                WheelStyleName = "style 369",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 369",
                Series = "X3 F25",
                Model = "",
                Except = "",
                Size = "9,5x19",
                Use = "back",
                ET = "",
                Kg = ""
            },
                //style 373
                new WheelSpecs
            {
                WheelStyleName = "style 373",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 373",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = ""
            },

                //style 374
                new WheelSpecs
            {
                WheelStyleName = "style 374",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 374",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = ""
            },
                //style 375
                new WheelSpecs
            {
                WheelStyleName = "style 375",
                Series = "X5 E70",
                Model = "X5 M",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "19,05"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 375",
                Series = "X5 E70",
                Model = "",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "20,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 375",
                Series = "X6 E71",
                Model = "X6 M",
                Except = "",
                Size = "10x21",
                Use = "front",
                ET = "ET 40",
                Kg = "19,05"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 375",
                Series = "X6 E71",
                Model = "X6 M",
                Except = "",
                Size = "11,5x21",
                Use = "back",
                ET = "ET 38",
                Kg = "20,00"
            },
                //style 376
                new WheelSpecs
            {
                WheelStyleName = "style 376",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 377
                new WheelSpecs
            {
                WheelStyleName = "style 377",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 378
                new WheelSpecs
            {
                WheelStyleName = "style 378",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 379
                new WheelSpecs
            {
                WheelStyleName = "style 379",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 380
                new WheelSpecs
            {
                WheelStyleName = "style 380",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 381
                new WheelSpecs
            {
                WheelStyleName = "style 381",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 382
                new WheelSpecs
            {
                WheelStyleName = "style 382",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 382",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "8x17",
                Use = "back",
                ET = "",
                Kg = ""
            },
                //style 385
                new WheelSpecs
            {
                WheelStyleName = "style 385",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 385",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "",
                Kg = ""
            },
                //style 388
                new WheelSpecs
            {
                WheelStyleName = "style 388",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7,5x18",
                Use = "front",
                ET = "",
                Kg = ""
            },
                new WheelSpecs
            {
                WheelStyleName = "style 388",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "back",
                ET = "",
                Kg = ""
            },
                //style 390
                new WheelSpecs
            {
                WheelStyleName = "style 390",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "ET 31",
                Kg = "8,30"
            },
                //style 391
                new WheelSpecs
            {
                WheelStyleName = "style 391",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "7,5x16",
                Use = "",
                ET = "ET 37",
                Kg = "9,80"
            },
                //style 392
                new WheelSpecs
            {
                WheelStyleName = "style 392",
                Series = "3er F30+",
                Model = "Sport Line",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 37",
                Kg = "10,97"
            },
                //style 393
                new WheelSpecs
            {
                WheelStyleName = "style 393",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 37",
                Kg = "10,43"
            },
                //style 394
                new WheelSpecs
            {
                WheelStyleName = "style 394",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 37",
                Kg = "10,75"
            },
                //style 395
                new WheelSpecs
            {
                WheelStyleName = "style 395",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "front",
                ET = "ET 37",
                Kg = "10,20"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 395",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8,5x17",
                Use = "back",
                ET = "ET 47",
                Kg = "11,00"
            },
                //style 396
                new WheelSpecs
            {
                WheelStyleName = "style 396",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 34",
                Kg = "12,70"
            },
                //style 397
                new WheelSpecs
            {
                WheelStyleName = "style 397",
                Series = "3er F30+",
                Model = "Sport Line",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 34",
                Kg = "12,00"
            },
                //style 398
                new WheelSpecs
            {
                WheelStyleName = "style 398",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8x18",
                Use = "front",
                ET = "ET 34",
                Kg = "11,82"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 398",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8,5x18",
                Use = "back",
                ET = "ET 47",
                Kg = "11,95"
            },
                //style 401
                new WheelSpecs
            {
                WheelStyleName = "style 401",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8x19",
                Use = "front",
                ET = "ET 36",
                Kg = "14,05"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 401",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8,5x19",
                Use = "back",
                ET = "ET 47",
                Kg = "14,05"
            },
                //style 404
                new WheelSpecs
            {
                WheelStyleName = "style 404",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8x20",
                Use = "front",
                ET = "ET 36",
                Kg = "14,95"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 404",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "back",
                ET = "ET 47",
                Kg = "15,00"
            },
                //style 405
                new WheelSpecs
            {
                WheelStyleName = "style 405",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "8x20",
                Use = "",
                ET = "ET 47",
                Kg = "15,00"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 405",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8x20",
                Use = "front",
                ET = "ET 36",
                Kg = "10,91"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 405",
                Series = "3er F30+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "back",
                ET = "ET 47",
                Kg = "10,94"
            },
                //style 408
                new WheelSpecs
            {
                WheelStyleName = "style 408",
                Series = "5er F10+",
                Model = "M5",
                Except = "",
                Size = "9x19",
                Use = "front",
                ET = "ET 32",
                Kg = "11,40"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 408",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x19",
                Use = "back",
                ET = "ET 25",
                Kg = "11,51"
            },
                //style 409
                new WheelSpecs
            {
                WheelStyleName = "style 409",
                Series = "5er F10+",
                Model = "M5",
                Except = "",
                Size = "9x20",
                Use = "front",
                ET = "ET 32",
                Kg = "12,75"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 409",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 25",
                Kg = "12,71"
            },
                //style 410
                new WheelSpecs
            {
                WheelStyleName = "style 410",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "16,47"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 410",
                Series = "5er F10+",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "16,49"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 410",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "8,5x20",
                Use = "front",
                ET = "ET 33",
                Kg = "16,47"
            },
                new WheelSpecs
            {
                WheelStyleName = "style 410",
                Series = "6er F12",
                Model = "",
                Except = "",
                Size = "9x20",
                Use = "back",
                ET = "ET 44",
                Kg = "16,49"
            },
                //style 411
                new WheelSpecs
            {
                WheelStyleName = "style 411",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7x16",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 412
                new WheelSpecs
            {
                WheelStyleName = "style 412",
                Series = "1er F20",
                Model = "",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "",
                Kg = ""
            },
                //style 413
                new WheelSpecs
            {
                WheelStyleName = "style 413",
                Series = "3er F30+",
                Model = "Modern Line",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 37",
                Kg = "11,29"
            },
                //style 414
                new WheelSpecs
            {
                WheelStyleName = "style 413",
                Series = "3er F30+",
                Model = "Luxury Line",
                Except = "",
                Size = "7,5x17",
                Use = "",
                ET = "ET 37",
                Kg = "10,75"
            },
                //style 415
                new WheelSpecs
            {
                WheelStyleName = "style 415",
                Series = "3er F30+",
                Model = "Modern Line",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 34",
                Kg = "11,65"
            },
                //style 416
                new WheelSpecs
            {
                WheelStyleName = "style 416",
                Series = "3er F30+",
                Model = "Luxury Line",
                Except = "",
                Size = "8x18",
                Use = "",
                ET = "ET 34",
                Kg = "12,85"
            },
};


            return Task.FromResult(wheelSpecs);
        }
    }
}
