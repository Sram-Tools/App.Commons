﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Common.Shared.Min.Extensions
{
	public static class EnumerableExtensions
	{
		public static bool IsEmpty([NotNullWhen(false)] this IEnumerable? source) => source is null || !source.Cast<object>().Any();

		[Pure]
		public static bool IsNotEmpty([NotNullWhen(true)] this IEnumerable? source) => source is not null && source.Cast<object>().Any();

		public static string Join<T>(this IEnumerable<T>? source, string separator = ", ") => source is null ? string.Empty : string.Join(separator, source);
	}
}