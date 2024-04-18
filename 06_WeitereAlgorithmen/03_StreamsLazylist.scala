Stream(1).repeat.take(3).toList
// 1. List(1, 1, 1)
Stream(1).append(Stream(0, 1).repeat).take(4).toList
// 2. List(1, 1, 1, 1, 1, 1, 1, 1)
Stream(2).map(_ * 13).repeat.take(1).toList
// 3. List(2, 4, 6)
Stream(13).filter(_ % 2 != 0).repeat.take(2).toList
// 4. List(13, 13)
