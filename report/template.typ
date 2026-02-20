// --- DESIGN PARAMETRE ---
// Vi bruger variabler her, så I nemt kan tweake det senere
#let body-font = "Roboto" // Eller "Segoe UI", "Inter", "Arial"
#let heading-font = "Roboto" 
#let code-font = "Fira Code" // Husk at installere denne font, den er fed til kode!
#let primary-color = rgb("#005ba3") // En professionel blå farve (Datamatiker-style)

// --- HOVED FUNKTIONEN ---
#let project(
  title: "",
  authors: (),
  date: none,
  body,
) = {
  // 1. DOKUMENT OPSÆTNING
  set document(author: authors, title: title)
  set page(
    paper: "a4",
    margin: (left: 3cm, right: 3cm, top: 3cm, bottom: 3cm), // Brede marginer for optimal læsning (ca 65 tegn)
    numbering: "1 / 1",
  )
  
  // 2. TEKST FORMATERING
  set text(font: body-font, lang: "da", size: 11pt)
  set par(justify: true, leading: 0.8em) // Justify gør kanterne lige, leading er linjeafstand

  // 3. OVERSKRIFTER (Nummerering 1.1, 1.1.1)
  set heading(numbering: "1.1")
  show heading: it => {
    set text(font: heading-font, weight: "bold", fill: primary-color)
    v(0.5em)
    block(it)
    v(0.5em)
  }

  // 4. KODE BLOKKE (Vigtigt for Datamatikere!)
  // Dette giver kodeblokke en let grå baggrund og runder hjørnerne
  show raw.where(block: true): block.with(
    fill: luma(240),
    inset: 10pt,
    radius: 4pt,
    width: 100%,
  )
  set raw(font: code-font)

  // 5. FORSIDEN
  align(center)[
    #v(3em)
    #image("assets/logo.png", width: 30%) // Læg jeres skole-logo i assets mappen
    #v(2em)
    #text(weight: "bold", size: 24pt, title)
    #v(1em)
    #text(size: 14pt, date)
    #v(2em)
    
    // Forfatter-liste
    #grid(
      columns: (1fr,) * calc.min(3, authors.len()),
      gutter: 1em,
      ..authors.map(author => strong(author)),
    )
    #v(2fr)
    
    // Semester info (Hardcoded eller parameter)
    Teknisk Rapport \
    Datamatiker uddannelsen \
    #datetime.today().display("[day]. [month repr:long] [year]")
  ]
  
  pagebreak()

  // 6. INDHOLDSFORTEGNELSE
  outline(depth: 2, indent: true)
  pagebreak()

  // 7. HOVEDINDHOLD
  // Sæt sidetal til at starte her, hvis I vil være fancy (valgfrit)
  counter(page).update(1)
  body
}