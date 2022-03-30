// animation on enemy death

class DeathAnimation {
  // attributes
  int x;
  int y;
  int deathCounter;

  // constructor
  DeathAnimation(int x, int y, int deathCounter) {
    this.x = x;
    this.y = y;
    this.deathCounter = deathCounter;
  }
  // methods
  void render(int k) {
    // reduce counter
    deathList.get(k).deathCounter--;
    // display image
    if (deathList.get(k).deathCounter < 5) {
      image(loadImage.deathImage[22], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 10) {
      image(loadImage.deathImage[21], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 15) {
      image(loadImage.deathImage[20], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 20) {
      image(loadImage.deathImage[19], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 25) {
      image(loadImage.deathImage[18], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 30) {
      image(loadImage.deathImage[17], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 35) {
      image(loadImage.deathImage[16], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 40) {
      image(loadImage.deathImage[15], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 45) {
      image(loadImage.deathImage[14], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 50) {
      image(loadImage.deathImage[13], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 55) {
      image(loadImage.deathImage[12], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 60) {
      image(loadImage.deathImage[11], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 65) {
      image(loadImage.deathImage[10], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 70) {
      image(loadImage.deathImage[9], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 75) {
      image(loadImage.deathImage[8], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 80) {
      image(loadImage.deathImage[7], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 85) {
      image(loadImage.deathImage[6], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 90) {
      image(loadImage.deathImage[5], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 95) {
      image(loadImage.deathImage[4], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 100) {
      image(loadImage.deathImage[3], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 105) {
      image(loadImage.deathImage[2], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 110) {
      image(loadImage.deathImage[1], deathList.get(k).x, deathList.get(k).y);
    } else if (deathList.get(k).deathCounter < 115) {
      image(loadImage.deathImage[0], deathList.get(k).x, deathList.get(k).y);
    }
    if (deathList.get(k).deathCounter == 0) {
      deathList.remove(deathList.get(k));
    }
  }
}  // end of class
