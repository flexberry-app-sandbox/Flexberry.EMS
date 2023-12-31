﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.EMS
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Organizer.
    /// </summary>
    // *** Start programmer edit section *** (Organizer CustomAttributes)

    // *** End programmer edit section *** (Organizer CustomAttributes)
    [AutoAltered()]
    [Caption("Организатор")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("OrganizerE", new string[] {
            "Name as \'Имя\'",
            "PhoneNumber as \'Телефонный номер\'",
            "EventHost as \'Организуемое мероприятие\'",
            "Mail as \'Почта\'",
            "EventPlan as \'План мероприятия\'",
            "Password as \'Пароль\'"})]
    [View("OrganizerL", new string[] {
            "Name as \'Имя\'",
            "PhoneNumber as \'Телефонный номер\'",
            "EventHost as \'Организуемое мероприятие\'",
            "Mail as \'Почта\'",
            "EventPlan as \'План мероприятия\'",
            "Password as \'Пароль\'"})]
    public class Organizer : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private decimal fPhoneNumber;
        
        private string fEventHost;
        
        private string fMail;
        
        private string fEventPlan;
        
        private string fPassword;
        
        // *** Start programmer edit section *** (Organizer CustomMembers)

        // *** End programmer edit section *** (Organizer CustomMembers)

        
        /// <summary>
        /// EventHost.
        /// </summary>
        // *** Start programmer edit section *** (Organizer.EventHost CustomAttributes)

        // *** End programmer edit section *** (Organizer.EventHost CustomAttributes)
        [StrLen(255)]
        public virtual string EventHost
        {
            get
            {
                // *** Start programmer edit section *** (Organizer.EventHost Get start)

                // *** End programmer edit section *** (Organizer.EventHost Get start)
                string result = this.fEventHost;
                // *** Start programmer edit section *** (Organizer.EventHost Get end)

                // *** End programmer edit section *** (Organizer.EventHost Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Organizer.EventHost Set start)

                // *** End programmer edit section *** (Organizer.EventHost Set start)
                this.fEventHost = value;
                // *** Start programmer edit section *** (Organizer.EventHost Set end)

                // *** End programmer edit section *** (Organizer.EventHost Set end)
            }
        }
        
        /// <summary>
        /// EventPlan.
        /// </summary>
        // *** Start programmer edit section *** (Organizer.EventPlan CustomAttributes)

        // *** End programmer edit section *** (Organizer.EventPlan CustomAttributes)
        [StrLen(255)]
        public virtual string EventPlan
        {
            get
            {
                // *** Start programmer edit section *** (Organizer.EventPlan Get start)

                // *** End programmer edit section *** (Organizer.EventPlan Get start)
                string result = this.fEventPlan;
                // *** Start programmer edit section *** (Organizer.EventPlan Get end)

                // *** End programmer edit section *** (Organizer.EventPlan Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Organizer.EventPlan Set start)

                // *** End programmer edit section *** (Organizer.EventPlan Set start)
                this.fEventPlan = value;
                // *** Start programmer edit section *** (Organizer.EventPlan Set end)

                // *** End programmer edit section *** (Organizer.EventPlan Set end)
            }
        }
        
        /// <summary>
        /// Mail.
        /// </summary>
        // *** Start programmer edit section *** (Organizer.Mail CustomAttributes)

        // *** End programmer edit section *** (Organizer.Mail CustomAttributes)
        [StrLen(255)]
        public virtual string Mail
        {
            get
            {
                // *** Start programmer edit section *** (Organizer.Mail Get start)

                // *** End programmer edit section *** (Organizer.Mail Get start)
                string result = this.fMail;
                // *** Start programmer edit section *** (Organizer.Mail Get end)

                // *** End programmer edit section *** (Organizer.Mail Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Organizer.Mail Set start)

                // *** End programmer edit section *** (Organizer.Mail Set start)
                this.fMail = value;
                // *** Start programmer edit section *** (Organizer.Mail Set end)

                // *** End programmer edit section *** (Organizer.Mail Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Organizer.Name CustomAttributes)

        // *** End programmer edit section *** (Organizer.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Organizer.Name Get start)

                // *** End programmer edit section *** (Organizer.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Organizer.Name Get end)

                // *** End programmer edit section *** (Organizer.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Organizer.Name Set start)

                // *** End programmer edit section *** (Organizer.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Organizer.Name Set end)

                // *** End programmer edit section *** (Organizer.Name Set end)
            }
        }
        
        /// <summary>
        /// Password.
        /// </summary>
        // *** Start programmer edit section *** (Organizer.Password CustomAttributes)

        // *** End programmer edit section *** (Organizer.Password CustomAttributes)
        [StrLen(255)]
        public virtual string Password
        {
            get
            {
                // *** Start programmer edit section *** (Organizer.Password Get start)

                // *** End programmer edit section *** (Organizer.Password Get start)
                string result = this.fPassword;
                // *** Start programmer edit section *** (Organizer.Password Get end)

                // *** End programmer edit section *** (Organizer.Password Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Organizer.Password Set start)

                // *** End programmer edit section *** (Organizer.Password Set start)
                this.fPassword = value;
                // *** Start programmer edit section *** (Organizer.Password Set end)

                // *** End programmer edit section *** (Organizer.Password Set end)
            }
        }
        
        /// <summary>
        /// PhoneNumber.
        /// </summary>
        // *** Start programmer edit section *** (Organizer.PhoneNumber CustomAttributes)

        // *** End programmer edit section *** (Organizer.PhoneNumber CustomAttributes)
        public virtual decimal PhoneNumber
        {
            get
            {
                // *** Start programmer edit section *** (Organizer.PhoneNumber Get start)

                // *** End programmer edit section *** (Organizer.PhoneNumber Get start)
                decimal result = this.fPhoneNumber;
                // *** Start programmer edit section *** (Organizer.PhoneNumber Get end)

                // *** End programmer edit section *** (Organizer.PhoneNumber Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Organizer.PhoneNumber Set start)

                // *** End programmer edit section *** (Organizer.PhoneNumber Set start)
                this.fPhoneNumber = value;
                // *** Start programmer edit section *** (Organizer.PhoneNumber Set end)

                // *** End programmer edit section *** (Organizer.PhoneNumber Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "OrganizerE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View OrganizerE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("OrganizerE", typeof(IIS.EMS.Organizer));
                }
            }
            
            /// <summary>
            /// "OrganizerL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View OrganizerL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("OrganizerL", typeof(IIS.EMS.Organizer));
                }
            }
        }
    }
}
