import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '../../models/Evento';
import { EventoService } from '../../services/evento.service';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
  //providers: [EventoService]
})
export class EventosComponent implements OnInit {

  modalRef?: BsModalRef;
  public eventos: Evento[] = [];
  eventosFiltrados: Evento[] = [];

  public larguraImagem: number = 150;
  public margemImagem: number = 2;
  public exibirImagem: boolean = true;
  private _filtroLista: string = '';


  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  public filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      evento => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
        )
  }

  isCollapsed = true;
  constructor(
    private eventoService: EventoService,
    private modalService: BsModalService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService
    ) {}

  public ngOnInit(): void {
    this.spinner.show();
    this.getEventos();
    /** spinner starts on init */

    setTimeout(() => {
      /** spinner ends after 5 seconds */

    }, 3000);
  }

  public alterarImagem(): void {
    this.exibirImagem = !this.exibirImagem;
  }

  public getEventos(): void {

    this.eventoService.getEventos().subscribe(
      (_eventos: Evento[]) => {
        this.eventos = _eventos;
        this.eventosFiltrados = this.eventos;
        this.spinner.hide();

      },
      (error) => {
        this.spinner.hide();
        this.toastr.error('Erro ao carregar os Eventos','Erro');

      }
    );
  }
  openModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  confirm(): void {
    this.modalRef?.hide();
    this.toastr.success('Evento Excluído com Sucesso','Excluir!');
  }

  decline(): void {
    this.modalRef?.hide();
  }
}
