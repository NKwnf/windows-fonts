# encoding:utf-8
import wx
import time


def catch_font():
    m = 0
    cache_list = []
    df = wx.App(False)
    cache = wx.FontEnumerator()
    fontList = cache.GetFacenames()
    for i in fontList:
        if '@' not in i:
            cache_list.append(i + '_')
            m = m + 1
    cache_str = ''.join(cache_list)
    print('This machine has a total of ' + str(m) + ' kinds of fonts.')
    return (cache_str)


if __name__ in '__main__':
    with open('c:/fonts_name.txt', 'w') as f:
        f.write(catch_font())
        f.close()
    print('Finished！Please open "c:/fonts_name.txt".')
    print('Automatically shut down after 30 seconds.')
    time.sleep(30)