using System.Configuration;

namespace DALLE_2_Frontend
{

    /**
     * Simple class that manages the saving of the user's API key
     */
    internal class UserSettings : ApplicationSettingsBase
    {

        [UserScopedSetting()]
        public string ApiKey
        {
            get
            {
                return ((string)this["ApiKey"]);
            }
            set
            {
                this["ApiKey"] = (string)value;
            }
        }

    }
}