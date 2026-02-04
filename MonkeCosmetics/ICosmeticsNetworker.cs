using ExitGames.Client.Photon;
using Photon.Realtime;

namespace MonkeCosmetics
{
	public interface ICosmeticsNetworker
	{
		void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps);
	}
}