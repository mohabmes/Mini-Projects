import requests
from bs4 import BeautifulSoup

baseurl=""
craweled = set()

def crawl(url, max_pages=10, recursive=0):
    page = 1

    if not url in craweled:
        while page <= max_pages:
            try:
                source_code = requests.get(url, allow_redirects=False)
            except:
                print("this URL ({}) is not accessible". format(url))
                page += 1
                continue
            # just get the code
            plain_text = source_code.text.encode('ascii', 'replace')
            # BeautifulSoup objects
            soup = BeautifulSoup(plain_text,'html.parser')
            for link in soup.findAll('a'):
                href = link.get('href')
                title = link.string
                # print(href + "\t" + str(title))
                # print(link)
                if not href[:4]==baseurl[:4]:
                    if not baseurl.endswith("/"):
                        href = baseurl + "/" + href
                    href = baseurl + href
                craweled.add(str(href))
            page += 1

        
        filename = baseurl.replace(":","_").replace("/","_") + ".txt"
        fw = open(filename, "w")
        for link in craweled:
            print(link)
            fw.write(link + "\n")

        if recursive is 1:
            recursive_crawl(craweled)

        fw.close()
# end of crawl


def recursive_crawl(list, r=0):
    for link in list:
        crawl(link, recursive=r)
# end of recursive_crawl

baseurl=input("URL: ")
crawl(baseurl, int(input("crawl recursivly[1/0]: ")))