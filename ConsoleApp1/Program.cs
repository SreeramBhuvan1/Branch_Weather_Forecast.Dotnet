using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Task1.Data;

var _contest = new Task1DbContext();
//var s =await _contest.Database.SqlQuery<int>($"select ID from SampleData") ;
/*var s = await _contest.SampleData.Select(q => new {Bu_codes=q.BU_CODES ,City=q.state.CITY}).ToListAsync();
string si;
string input= "AB100";
foreach( var r in s)
{
    if (r.Bu_codes == input)
    {
        si = r.City;
    }
}*/
/*var s = await _contest.stateTables.Where(p => p.ID==100).ToListAsync();
foreach(var i in s)
{
    Console.WriteLine(i.CITY);
}*/