namespace Tsinswreng.CsTempus;

using TStruct = UnixMs;
using TPrimitive = i64;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public partial struct UnixMs(TPrimitive V)
	:IEquatable<UnixMs>
	,IComparable
{
	public static TStruct Zero = new(0);
	public TPrimitive Value{get;set;} = V;

	public UnixMs():this(DateTimeOffset.Now.ToUnixTimeMilliseconds()){

	}

	public static TStruct FromUnixMs(i64 Ms ){
		return new (Ms);
	}
}
