with open('dynamic_input_data.txt') as content_file:
  
  for index, line in enumerate(content_file):
    data = line.strip().split("|")  
    if len(data) == 11:
      print(len(data))

    #config_data.append([data[0],data[1], data[2], data[3], data[4],data[5],data[6],data[7],data[8],data[9],data[10]])

   