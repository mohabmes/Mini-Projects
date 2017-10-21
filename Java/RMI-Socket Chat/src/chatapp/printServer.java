
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
        
public class printServer extends UnicastRemoteObject implements PrintInterface {
    
//    ServerSocket server;

    public printServer() throws RemoteException {

        super();
    }
    

    public void print(final String s) throws RemoteException{
        System.out.println(s);
    }


    public static void main(String[] args) {
        Registry reg;
        try{
            reg = LocateRegistry.createRegistry(951);
            reg.rebind("server", new printServer());
        } catch(Throwable t){
            t.printStackTrace();
        }
    }
}
