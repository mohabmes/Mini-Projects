
import java.util.ArrayList;

public class Playlist implements IComponent{
	public String playlistName;
	public ArrayList<IComponent> playlist = new ArrayList();

	public Playlist(String playlistName) {
		this.playlistName = playlistName;
	}

	public String getName() {
		return playlistName;
	}
	public void play() {
		for(IComponent component : playlist) {
			component.play();
	    }
	}
	public void setPlaybackSpeed(float s) {
		System.out.println("PlaySpeed .. ");
	}
	
	public void add(IComponent s) {
		playlist.add(s);
	}
	public void remove(IComponent s) {
		playlist.remove(playlist.indexOf(s));
	}
	
	public void showContent() {
		System.out.println(getName() + "content");
		for (int i = 0; i < playlist.size(); i++) {
			String item = playlist.get(i).getName().toString();
			String type = playlist.get(i).getClass().toString();
			System.out.println(item + " : "+type);
		}
	}


}
