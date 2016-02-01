using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Contacts;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MoveToW10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            // write contacts
            //ContactStore store = await ContactManager.RequestStoreAsync(ContactStoreAccessType.AppContactsReadWrite);
            //var lists = await store.FindContactListsAsync();
            //ContactList list = lists.FirstOrDefault((x) => x.DisplayName == "myPrivateList");
            //if (list == null)
            //{
            //    list = await store.CreateContactListAsync("myPrivateList");
            //    list.OtherAppReadAccess = ContactListOtherAppReadAccess.Full;
            //    list.OtherAppWriteAccess = ContactListOtherAppWriteAccess.SystemOnly;
            //    await list.SaveAsync();
            //}

            //Contact contact = new Contact();
            //contact.Name = "John";
            //contact.Phones.Add(new ContactPhone() { Kind = ContactPhoneKind.Mobile, Number = "0917987777211" });
            //await list.SaveContactAsync(contact);

            // write phone call history
            PhoneCallHistoryStore store = PhoneCallHistoryManager.RequestStoreAsync(PhoneCallHistoryStoreAccessType.AllEntriesLimitedReadWrite).GetResults();
            PhoneCallHistoryEntry entry = new PhoneCallHistoryEntry();
            await store.SaveEntryAsync(entry);

            // write sms

        }
    }
}
