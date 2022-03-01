namespace API.Entities
{
    /// <summary>
    /// Eigenschaften eines Nutzers
    /// </summary>
    public class User
    {
        // ID eines Benutzers
        public int Id { get; set; }

        // Vorname eines Benutzers
        public string Firstname { get; set; }

        // Nachname eines Benutzers
        public string Lastname { get; set; }

        // Login name eines Benutzers
        public string Login { get; set; }

        // Passwort eines Benutzers
        public string Password { get; set; }

        // Datum an dem der Nutzer erstellt wurde
        public DateTime CreationDate { get; set; }
      
        // Datum an dem der Nutzer das letzte Mal geändert worden ist
        public DateTime ChangeDate { get; set; }
    }
}
