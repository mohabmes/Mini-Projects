package com.example.sharingapp;

import android.content.Context;

public class DeleteContactCommand extends Command {
    private Contact contact;
    private ContactList contactList;
    private Context context​;

    public DeleteContactCommand(Contact contact, ContactList contactList, Context context){
        this.contact = contact;
        this.contactList = contactList;
        this.context​ = context;
    }

    @Override
    public void execute(){
        contactList.deleteContact(contact);
        setIsExecuted(contactList.saveContacts(context​));
    }
}
