import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.sql.Time;
import java.time.LocalTime;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.Date;
import java.rmi.registry.LocateRegistry;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;

public class server extends Thread{
    
    ServerSocket server1;

    public server() {
        try{
        server1 = new ServerSocket(7119);
        }catch(IOException ex){
            System.out.println(ex.getMessage());
        }
    }

    @Override
    public void run() {
        Socket aClient;
        while(true){
            try {
                System.out.println("Waiting ...");
                aClient = server1.accept();
                System.out.println("New Client is HERE!!");
                DataInputStream reader =
                        new DataInputStream(aClient.getInputStream());
                DataOutputStream writter = 
                        new DataOutputStream(aClient.getOutputStream());
                
                // Sent msg to the client
                String aClientMsg = reader.readUTF();
                writter.writeUTF("Successfully Sent");

                
                // Send the content to Printing server
                PrintInterface rmi;
                Registry reg;

                try{
                    reg = LocateRegistry.getRegistry(951);
                    rmi = (PrintInterface) reg.lookup("server");
                    rmi.print("Port : " + aClient.getPort());
                    rmi.print("Host : " + aClient.getLocalAddress());
                    rmi.print(aClientMsg);
                    rmi.print("On : " + new Date() + "\n\n");
                    
                } catch(Throwable t){
                    t.printStackTrace();
                }
                //=====================================
                
                reader.close();
                writter.close();
                aClient.close();
            } catch (IOException ex) {
                System.out.println(ex.getMessage());
            }
        }
    }
    
    public static void main(String[] args) {
        new server().start();
        
        
    }
    
    
}