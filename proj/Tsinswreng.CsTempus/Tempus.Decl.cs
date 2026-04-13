namespace Tsinswreng.CsTempus;

using TStruct = Tempus;
using TPrimitive = i64;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public partial struct Tempus(TPrimitive V)
	:IEquatable<Tempus>
	,IComparable
{
	public static TStruct Zero = new(0);
	public TPrimitive Value{get;set;} = V;

	public Tempus():this(DateTimeOffset.Now.ToUnixTimeMilliseconds()){

	}

	public static TStruct FromUnixMs(i64 Ms ){
		return new (Ms);
	}
}
