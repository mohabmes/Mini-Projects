

public class Song implements IComponent{
	public String songName;
	public String artist;
	public float speed = 1; // Default playback speed

	public Song(String songName, String artist ) {
		this.songName = songName;
		this.artist = artist; 
	}
	
	public String getName() {
		return songName;
	}
	public void play() {
		System.out.println("Play .. ");
	}
	public void setPlaybackSpeed(float s) {
		System.out.println("PlaySpeed .. ");
	}
	public String getArtist() {
		return artist;
	}
	
}
