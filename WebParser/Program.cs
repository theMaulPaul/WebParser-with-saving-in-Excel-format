using System.Text.Json;
using System.Text.RegularExpressions;
using WebParser;
using ClosedXML.Excel;
using WebParser.Models;
using WebParser.Service;

var webPage = "https://www.swansonvitamins.com/ncat1/Vitamins+and+Supplements/ncat2/Multivitamins/ncat3/Multivitamins+with+Iron";
var parser = new FileParser();
WriteToFile transition = new SaveToXLS();

var list = parser.ParseFile(webPage);
transition.SaveAs("productsList.xlsx", list);
Console.WriteLine("File has been succesfully written");