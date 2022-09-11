static class ExtensionMethod
{
	public static void Print<T>(this List<T> list)
		=> list.ForEach(l => Console.WriteLine(l));

	public static void Print<T>(this IEnumerable<T> collection)
	{
		foreach (var item in collection)
			Console.WriteLine(item);
	}
}