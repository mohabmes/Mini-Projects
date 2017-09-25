import requests
from bs4 import BeautifulSoup

def crawl(url, max_pages=10, recursive=0):
    page = 1
    craweled = set()

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
            craweled.add(str(href))
        page += 1

    fw = open("ds.txt", "a")
    for link in craweled:
        print(link)
        fw.write(link + "\n")

    if recursive is 1:
        recursive_crawl(craweled)

    fw.close()
# end of crawl


def recursive_crawl(list, r=0):
    for link in list:
        print(link)
        crawl(link, recursive=r)
# end of recursive_crawl


crawl('https://www.youtube.com/', 10, 0)