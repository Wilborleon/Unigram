// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTopPeerCategoryPhoneCalls : TLTopPeerCategoryBase 
	{
		public TLTopPeerCategoryPhoneCalls() { }
		public TLTopPeerCategoryPhoneCalls(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TopPeerCategoryPhoneCalls; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1E76A78C);
		}
	}
}