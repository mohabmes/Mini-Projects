import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.rmi.registry.LocateRegistry;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.util.Scanner;

public class client {
    public static void main(String[] args) {
        String Msg;
        while(true){
            try {
                Scanner scanner = new Scanner(System.in); 
                Msg = scanner.nextLine();

                Socket client = new Socket("127.0.0.1", 7119);
                DataInputStream reader = new DataInputStream(client.getInputStream());
                DataOutputStream writer = new DataOutputStream(client.getOutputStream());

                writer.writeUTF(Msg);
                String ServerMsg = reader.readUTF();
                System.out.println(ServerMsg);

                reader.close();
                writer.close();
                client.close();
            } catch (IOException ex) {
                System.out.println(ex.getMessage());
            }
        }
    }
}
