class RnaTranscription {

    String transcribe(String dnaStrand) {

        String rna = dnaStrand;

        for(var i = 0; i <= dnaStrand.length(); i++){
            if(dnaStrand.charAt(i) == 'G')
            {
                rna.charAt(i) = 'C';
            }
        }
    }

}
