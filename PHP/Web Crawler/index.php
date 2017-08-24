<label for="url">URL</label>
<form method="GET">
	<input type="text" name="url" id="url">
	<input type="checkbox" name="only" id="only" value="true"><label for="only">Only This Page</label>
	<input type="submit" name="submit" value="Crawl">
</form>

<?php
if(isset($_GET['submit'])){
	if(isset($_GET['url'])){
	
		$page = $_GET['url'];

		$crawled = array();
		$Alldata ="";

		function crawl($url){
			
			global $crawled;
			
			$doc = new DOMDocument();
			@$doc->loadHTML(file_get_contents($url));
			
			$linkarr = $doc->getElementsByTagName("a");
			
			foreach($linkarr as $link){
				global $Alldata;
				
				$l = $link->getAttribute("href");
				
				if (substr($l, 0, 3) == "www") {
					$l = parse_url($url)["scheme"]."://".$l;
				}else if (substr($l, 0, 1) == "/" && substr($l, 0, 2) != "//") {
					$l = parse_url($url)["scheme"]."://".parse_url($url)["host"].$l;
				} else if (substr($l, 0, 2) == "//") {
					$l = parse_url($url)["scheme"].":".$l;
				} else if (substr($l, 0, 2) == "./") {
					$l = parse_url($url)["scheme"]."://".parse_url($url)["host"].dirname(parse_url($url)["path"]).substr($l, 1);
				} else if (substr($l, 0, 1) == "#") {
					$l = parse_url($url)["scheme"]."://".parse_url($url)["host"].parse_url($url)["path"].$l;
				} else if (substr($l, 0, 3) == "../") {
					$l = parse_url($url)["scheme"]."://".parse_url($url)["host"]."/".$l;
				} else if (substr($l, 0, 11) == "javascript:") {
					continue;
				} else if (substr($l, 0, 5) != "https" && substr($l, 0, 4) != "http") {
					$l = parse_url($url)["scheme"]."://".parse_url($url)["host"]."/".$l;
				}
				
				if(!in_array($l, $crawled)){
					$crawled[] = $l;
					echo details($l). "<br>";
					$Alldata .= details($l). "\n";
					//echo $l ;
				}
				
			}
			
			if(!isset($_GET['only']) == "true"){
				foreach ($crawled as $site) {
					crawl($site);
				}
			}
			//file_put_contents('pages.json', $Alldata);
		}

		function details($url){
			$doc = new DOMDocument();
			@$doc->loadHTML(@file_get_contents($url));
			
			$linkarr = $doc->getElementsByTagName("a");
			
			$description = "";
			$keywords = "";
			@$metas = $doc->getElementsByTagName("meta");
			
			@$title = $doc->getElementsByTagName("title");
			@$title = $title->item(0)->nodeValue;
			
			for ($i = 0; $i < $metas->length; $i++) {
				$meta = $metas->item($i);
				if (strtolower($meta->getAttribute("name")) == "description")
					$description = $meta->getAttribute("content");
				if (strtolower($meta->getAttribute("name")) == "keywords")
					$keywords = $meta->getAttribute("content");
			}
			return '{ "Title": "'.str_replace("\n", "", $title).'", "Description": "'.str_replace("\n", "", $description).'", "Keywords": "'.str_replace("\n", "", $keywords).'", "URL": "'.$url.'"},';

		}

		crawl($page);
	}
}

//print_r($crawled);
