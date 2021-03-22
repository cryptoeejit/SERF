using System;
using System.Collections.Generic;
using Blockcore.Consensus.Checkpoints;
using SERF.Networks;
using SERF.Networks.Setup;
using NBitcoin;

namespace SERF
{
   internal class SERFSetup
   {
      internal static SERFSetup Instance = new SERFSetup();

      internal CoinSetup Setup = new CoinSetup
      {
         FileNamePrefix = "serf",
         ConfigFileName = "serf.conf",
         Magic = "01-4F-4E-4D",
         CoinType = 712, // SLIP-0044: https://github.com/satoshilabs/slips/blob/master/slip-0044.md,
         PremineReward = 1000000,
         PoWBlockReward = 8,
         PoSBlockReward = 2,
         LastPowBlock = 1000000,
         GenesisText = "15-06-1215 - JOHN, by the grace of God King of England", // The New York Times, 2020-04-16
         TargetSpacing = TimeSpan.FromSeconds(120),
         ProofOfStakeTimestampMask = 0x0000000F, // 0x0000003F // 64 sec
         PoSVersion = 3
      };

      internal NetworkSetup Main = new NetworkSetup
      {
         Name = "SERFMain",
         RootFolderName = "serf",
         CoinTicker = "SERF",
         DefaultPort = 15111,
         DefaultRPCPort = 15112,
         DefaultAPIPort = 15113,
         PubKeyAddress = 63, // B https://en.bitcoin.it/wiki/List_of_address_prefixes
         ScriptAddress = 110, // b
         SecretAddress = 160,
         GenesisTime = 1616389546,
         GenesisNonce = 370524,
         GenesisBits = 0x1E0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "000004e1500b3bed4c877cccd9ff06577ce466b571d7571ff834f10afdc83dc5",
         HashMerkleRoot = "528719844c7830da75c7c35804cc5267ddc629dcdbbecfef89c768078a7287bd",
         DNS = new[] { "seed1.serfnet.info", "seed2.serfnet.info", "serf.seed.blockcore.net" },
         Nodes = new[] { "45.32.246.83", "78.141.230.15" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup RegTest = new NetworkSetup
      {
         Name = "SERFRegTest",
         RootFolderName = "serfregtest",
         CoinTicker = "TSERF",
         DefaultPort = 25111,
         DefaultRPCPort = 25112,
         DefaultAPIPort = 25113,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1616389587,
         GenesisNonce = 89681,
         GenesisBits = 0x1F00FFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00005605a91509d63fc73e64d041902780b41dbfa6508d22e01a575dce2e5f36",
         HashMerkleRoot = "3897cd4b244e86ab20957c4cd89877fd4a48c666660eed3c8268bfed61390b36",
         DNS = new[] { "seedregtest1.serf.blockcore.net", "seedregtest2.serf.blockcore.net", "seedregtest.serf.blockcore.net" },
         Nodes = new[] { "45.32.246.83", "78.141.230.15" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup Test = new NetworkSetup
      {
         Name = "SERFTest",
         RootFolderName = "serftest",
         CoinTicker = "TSERF",
         DefaultPort = 35111,
         DefaultRPCPort = 35112,
         DefaultAPIPort = 35113,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1616389596,
         GenesisNonce = 514,
         GenesisBits = 0x1F0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "000c4426f33bf909ce04913ed570badfdcdfc367904294070867cdc0b14deb86",
         HashMerkleRoot = "e017bbb852d5c79666cf83b7a4e837f9ee00f742566daade7160640ff5f90cc9",
         DNS = new[] { "seedtest1.serf.blockcore.net", "seedtest2.serf.blockcore.net", "seedtest.serf.blockcore.net" },
         Nodes = new[] { "45.32.246.83", "78.141.230.15" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      public bool IsPoSv3()
      {
         return Setup.PoSVersion == 3;
      }

      public bool IsPoSv4()
      {
         return Setup.PoSVersion == 4;
      }
   }
}
