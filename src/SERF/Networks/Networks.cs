using Blockcore.Networks;

namespace SERF.Networks
{
   public static class Networks
   {
      public static NetworksSelector SERF
      {
         get
         {
            return new NetworksSelector(() => new SERFMain(), () => new SERFTest(), () => new SERFRegTest());
         }
      }
   }
}
