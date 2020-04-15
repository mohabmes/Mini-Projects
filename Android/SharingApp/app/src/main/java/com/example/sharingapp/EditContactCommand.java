package com.example.sharingapp;

import android.content.Context;

public class EditContactCommand extends Command {
    private Contact old_contact;
    private Contact new_contact;
    private ContactList contactList;
    private Context context​;

    public EditContactCommand(Contact new_contact, Contact old_contact, ContactList contactList, Context context){
        this.new_contact = new_contact;
        this.old_contact = old_contact;
        this.contactList = contactList;
        this.context​ = context;
    }

    @Override
    public void execute(){
        contactList.deleteContact(old_contact);
        contactList.addContact(new_contact);
        setIsExecuted(contactList.saveContacts(context​));
    }
}