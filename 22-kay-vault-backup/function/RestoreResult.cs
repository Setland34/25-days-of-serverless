using System.Collections.Generic;

namespace Christmas.BackupKeyVault
{
    public class RestoreResult
    {
        public List<string> SecretsResult { get; set; }

        public List<string> KeysResult { get; set; }

        public List<string> CertificatesResult { get; set; }
    }
}