using MonkeCosmetics.Data;
using UnityEngine;

namespace MonkeCosmetics
{
	public interface IAsset
	{
        string FileName { get; }
        CosmeticDescriptor Descriptor { get; }
	}
}