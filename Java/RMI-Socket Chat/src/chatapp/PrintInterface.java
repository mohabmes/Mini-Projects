//package rmi;

import java.rmi.Remote;
import java.rmi.RemoteException;


public interface PrintInterface extends Remote {
    public abstract void print(final String s) throws RemoteException;
}



