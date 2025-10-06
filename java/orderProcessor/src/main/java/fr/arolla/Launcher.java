package fr.arolla;

import java.util.List;

public class Launcher {

    public static void main(String[] args) {
        OrderProcessor orderProcessor = new OrderProcessor();
        orderProcessor.ProcessOrder("VIP123", List.of("BOOK", "DVD"), "CREDIT", "EXPRESS");
    }
}
