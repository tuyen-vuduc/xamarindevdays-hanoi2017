namespace HanoiDevDays.CrossClock.DTOs
{
    public static class TimeZoneData
    {
        static readonly TimeZoneDto[] data = {
            new TimeZoneDto {
                CountryCode = "AD",
                CountryName = "Andorra",
                ZoneName = "Europe/Andorra",
                GmtOffset = 7200,
                Timestamp = 1507725463
            },
            new TimeZoneDto {
                CountryCode = "AE",
                CountryName = "United Arab Emirates",
                ZoneName = "Asia/Dubai",
                GmtOffset = 14400,
                Timestamp = 1507732663
            },
            new TimeZoneDto {
                CountryCode = "AF",
                CountryName = "Afghanistan",
                ZoneName = "Asia/Kabul",
                GmtOffset = 16200,
                Timestamp = 1507734463
            },
            new TimeZoneDto {
                CountryCode = "AG",
                CountryName = "Antigua and Barbuda",
                ZoneName = "America/Antigua",
                GmtOffset = -14400,
                Timestamp = 1507703863
            },
            new TimeZoneDto {
                CountryCode = "AI",
                CountryName = "Anguilla",
                ZoneName = "America/Anguilla",
                GmtOffset = -14400,
                Timestamp = 1507703863
            },
            new TimeZoneDto {
                CountryCode = "AL",
                CountryName = "Albania",
                ZoneName = "Europe/Tirane",
                GmtOffset = 7200,
                Timestamp = 1507725463
            },
            new TimeZoneDto {
                CountryCode = "AM",
                CountryName = "Armenia",
                ZoneName = "Asia/Yerevan",
                GmtOffset = 14400,
                Timestamp = 1507732663
            },
            new TimeZoneDto {
                CountryCode = "AO",
                CountryName = "Angola",
                ZoneName = "Africa/Luanda",
                GmtOffset = 3600,
                Timestamp = 1507721863
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Casey",
                GmtOffset = 39600,
                Timestamp = 1507757863
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Davis",
                GmtOffset = 25200,
                Timestamp = 1507743463
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/DumontDUrville",
                GmtOffset = 36000,
                Timestamp = 1507754263
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Mawson",
                GmtOffset = 18000,
                Timestamp = 1507736263
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/McMurdo",
                GmtOffset = 46800,
                Timestamp = 1507765063
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Palmer",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Rothera",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Syowa",
                GmtOffset = 10800,
                Timestamp = 1507729063
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Troll",
                GmtOffset = 7200,
                Timestamp = 1507725463
            },
            new TimeZoneDto {
                CountryCode = "AQ",
                CountryName = "Antarctica",
                ZoneName = "Antarctica/Vostok",
                GmtOffset = 21600,
                Timestamp = 1507739863
            },
            new TimeZoneDto {
                CountryCode = "AR",
                CountryName = "Argentina",
                ZoneName = "America/Argentina/Buenos_Aires",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AR",
                CountryName = "Argentina",
                ZoneName = "America/Argentina/Catamarca",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AR",
                CountryName = "Argentina",
                ZoneName = "America/Argentina/Cordoba",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AR",
                CountryName = "Argentina",
                ZoneName = "America/Argentina/Jujuy",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AR",
                CountryName = "Argentina",
                ZoneName = "America/Argentina/La_Rioja",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AR",
                CountryName = "Argentina",
                ZoneName = "America/Argentina/Mendoza",
                GmtOffset = -10800,
                Timestamp = 1507707463
            },
            new TimeZoneDto {
                CountryCode = "AR",
                CountryName = "Argentina",
                ZoneName = "America/Argentina/Rio_Gallegos",
                GmtOffset = -10800,
                Timestamp = 1507707463
            }
        };

        public static TimeZoneDto[] GetTimeZones()
        {
            return data;
        }
    }
}
